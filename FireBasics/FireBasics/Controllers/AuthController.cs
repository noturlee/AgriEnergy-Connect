using Firebase.Auth;
using FireBasics.Logger;
using FireBasics.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NuGet.Common;
using System.Diagnostics;

namespace FireBasics.Controllers
{
    public class AuthController : Controller
    {
        private ILog iLog;
        private readonly AgrienergyContext _context; 

        FirebaseAuthProvider auth;

        public AuthController(AgrienergyContext context) // Dependency injection
        {
            _context = context; // Ensure _context is initialized
            iLog = Log.GetInstance();
            auth = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyBxp6SwUyRGTYZlhZHmCGq4XL8WFMVWQrQ"));
        }

        public IActionResult Registration()
        {
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("_UserToken")))
            {
                return RedirectToAction("Index", "Home"); // Redirect to the homepage if logged in
            }
            return View();
        }

        public IActionResult SignIn()
        {
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("_UserToken")))
            {
                return RedirectToAction("Index", "Home"); // Redirect to the homepage if logged in
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registration(AuthModel authModel)
        {
            try
            {
                var fbAuthLink = await auth.CreateUserWithEmailAndPasswordAsync(authModel.Email, authModel.Password);

                if (fbAuthLink?.User == null)
                {
                    ModelState.AddModelError(string.Empty, "Failed to create user in Firebase.");
                    return View(authModel);
                }

                string firebaseUid = fbAuthLink.User.LocalId; // Get Firebase UID
                string token = fbAuthLink.FirebaseToken; // Get Firebase token

                if (token == null)
                {
                    ModelState.AddModelError(string.Empty, "Failed to retrieve a valid token.");
                    return View(authModel);
                }

                // Set session with Firebase token
                HttpContext.Session.SetString("_UserToken", token);

                var newUser = new FireBasics.Models.User
                {
                    FirebaseUid = firebaseUid,
                    Role = "FARMER", // Or 'EMPLOYEE', depending on your logic
                    Name = authModel.Name, // User-provided name
                    Dob = authModel.Dob, // User-provided date of birth
                    Bio = authModel.Bio // User-provided bio
                };

                _context.Users.Add(newUser); // Save to the local database
                await _context.SaveChangesAsync(); // Persist changes to the database

                // Redirect after successful registration
                return RedirectToAction("Index", "Home");
            }
            catch (FirebaseAuthException ex)
            {
                var firebaseEx = JsonConvert.DeserializeObject<FirebaseError>(ex.ResponseData);
                ModelState.AddModelError(string.Empty, "Registration error: " + firebaseEx.error.message);
                return View(authModel);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An unexpected error occurred: " + ex.Message);
                return View(authModel);
            }
        }

        [HttpPost]

        public async Task<IActionResult> SignIn(AuthModel authModel)
        {
            try
            {
                var fbAuthLink = await auth.SignInWithEmailAndPasswordAsync(authModel.Email, authModel.Password);
                string token = fbAuthLink.FirebaseToken;

                if (token != null)
                {
                    HttpContext.Session.SetString("_UserToken", token); // Save token in session
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(String.Empty, "Invalid login credentials.");
                    iLog.LogException("User Login Failed - " + authModel.Email);
                    return View(authModel); // Return the sign-in view with errors
                }
            }
            catch (FirebaseAuthException ex)
            {
                var firebaseEx = JsonConvert.DeserializeObject<FirebaseError>(ex.ResponseData);
                ModelState.AddModelError(String.Empty, "Login error: " + firebaseEx.error.message);
                iLog.LogException("User Login Failed - " + authModel.Email);
                return View(authModel); // Return the sign-in view with errors
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty, "An unexpected error occurred: " + ex.Message);
                iLog.LogException("User Login Failed - " + authModel.Email);
                return View(authModel); // Return the sign-in view with errors
            }
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("_UserToken");
            return RedirectToAction("SignIn");
        }
    }
}
