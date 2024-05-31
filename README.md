<img src ="Images/Banner.gif" />

# Agri-Energy Connect

Agri-Energy Connect is a forward-thinking initiative bridging agriculture and green energy in South Africa. As an MVC platform, it fosters sustainable practices and integrates renewable energy solutions. It serves as a vital link between farmers and technology providers, driving innovation for a greener future.

## Table of Contents

1. [Introduction](#introduction)
2. [Functionality Requirements](#functionality-requirements)
3. [Setup Instructions](#setup-instructions)
4. [Installation and Setup](#installation-and-setup)
5. [Building and Running the Prototype](#building-and-running-the-prototype)
6. [System Functionalities and User Roles](#system-functionalities-and-user-roles)
7. [Roadmap](#roadmap)
8. [Images](#images)
9. [Demo Video](#demo-video)
10. [Technology Stack](#technology-stack)
11. [Coding Activity](#coding-activity)
12. [Get Started](#get-started)
13. [Contributing](#contributing)
14. [Contributing](#Reference-List)


## 🟢 Introduction

In response to the growing need for sustainable agricultural practices and the integration of green energy solutions in South Africa, the visionary initiative named "Agri-Energy Connect" has been conceptualized. This initiative aims to develop an innovative web platform that connects the agricultural sector with green energy technology providers. Key features of the platform include a Green Energy Marketplace and a platform for farmers to sell their products.

<img src ="https://media.baamboozle.com/uploads/images/604865/1676058321_96119_gif-url.gif"/>

### Green Energy Marketplace

- A marketplace for green energy solutions tailored to agricultural needs, such as solar-powered irrigation systems, wind turbines for farms, and biogas energy solutions.

### Farmer Product Selling Platform

- A platform where farmers can sell their products.

## 🟠 Functionality Requirements

1. **Database Development and Integration:**
   - Design and integrate a relational database to manage information about farmers and their products.
   - Populate the database with sample data to simulate real-world scenarios, ensuring the demonstration is robust and comprehensive.

2. **User Role Definition and Authentication System:**
   - Two user roles within the system:
     - Farmer: Can add products to their profile and view their own product listings.
     - Employee: Can add new farmer profiles, view all products from specific farmers, and use filters for product searching.
   - There is a secure login functionality with authentication mechanisms to protect user data and ensure role-specific access.

3. **Functional Features for Farmers and Employees:**
   - For Farmers:
     - Product addition feature where farmers can add new products with details like name, category, and production date.
   - For Employees:
     - Ability to add new farmer profiles with essential details.
     - Capability to view and filter a comprehensive list of products from any farmer based on criteria such as date range and product type.

## 🟢 Setup Instructions

Follow these step-by-step instructions to set up the development environment:

1. **Tools Required:**
   - Visual Studio (preferably the latest version)
   - .NET Framework
   - Microsoft.EntityFrameworkCore

2. **Downloading the App:**
   - Clone the repository to your local machine.

3. **Dependencies:**
   - Open the project in Visual Studio.
   - Ensure you have the necessary dependencies installed, including .NET Framework and Microsoft.EntityFrameworkCore packages.
  
   <img src ="https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/aa9d2b73-a2e7-4148-b638-2b258ffe7644/dfulzfg-1f018aa1-8021-4fc7-9032-710dd7953e43.gif?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcL2FhOWQyYjczLWEyZTctNDE0OC1iNjM4LTJiMjU4ZmZlNzY0NFwvZGZ1bHpmZy0xZjAxOGFhMS04MDIxLTRmYzctOTAzMi03MTBkZDc5NTNlNDMuZ2lmIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.F5bQbkIMPvev0TT1n39I-kwM3HrmJH75Z_dXT2rS0hs"/>

## 🟠 Installation and Setup

Once you have cloned the repository and ensured all dependencies are installed, follow these steps to install and set up the application:

1. Navigate to the root directory of the project.
2. Run the following command to restore any missing dependencies:
3. Configure the database connection string in the `appsettings.json` file.
4. Run the database migrations
5. Once the database is set up, you can now build and run the application.

## Building and Running the Prototype

To build and run the prototype, follow these steps:

1. Build the solution in Visual Studio.
2. Run the application from Visual Studio or deploy it to a web server.

## System Functionalities and User Roles

- **Farmers:**
- Add new products to their profile.
- View their own product listings.
- **Employees:**
- Add new farmer profiles with essential details.
- View and filter a comprehensive list of products from any farmer based on criteria such as date range and product type.
![gif](https://cdn.pixabay.com/animation/2023/06/29/06/23/06-23-06-393_512.gif)

## 🟢 Roadmap

Here's our roadmap for Agri-Energy Connect, with an overview of completed tasks and planned features.

### Completed
- [x] Database schema design and integration.
- [x] User authentication system with role-based access control.
- [x] Basic CRUD functionality for farmers and employees.
- [x] Implementation of Green Energy Marketplace.
- [x] Implementation of search and filtering functionality for products.

### In Progress
- [ ] Integration of payment gateway for product transactions.

### Planned
- [ ] Enhancement of user interface for improved user experience.
- [ ] Integration with external APIs for weather forecasting.
- [ ] Implementation of analytics dashboard for productivity insights.



## 🟢 Images

### Teaser pics of AgriEnergy-Connect
![image](https://github.com/VCDN-2024/prog7311-part-2-Leighche/assets/104209100/a1a8c6bc-3b77-4ed1-ae35-63b3d2577bd1)
![image](https://github.com/VCDN-2024/prog7311-part-2-Leighche/assets/104209100/f0a20c23-ae14-4f83-8425-1fd4b2ed9b3d)
![image](https://github.com/VCDN-2024/prog7311-part-2-Leighche/assets/104209100/11d15d28-a35e-4f62-a10f-a0fc2f47ed1d)
![image](https://github.com/VCDN-2024/prog7311-part-2-Leighche/assets/104209100/44061aae-a047-40e1-826c-53a715f8ecdc)
![image](https://github.com/VCDN-2024/prog7311-part-2-Leighche/assets/104209100/38560584-a169-405f-955b-99b015f0dc93)
![image](https://github.com/VCDN-2024/prog7311-part-2-Leighche/assets/104209100/7c36fc5d-b873-493e-bbe5-a6f04de9633c)

## Demo Video

### Tap the image to watch the video
[![Demo Video](https://github.com/VCDN-2024/prog7311-part-2-Leighche/assets/104209100/23b172e4-a4f5-4bd7-90fe-d4eba3a63e24)](https://youtu.be/anhSqbKigp8)

<h2 align="left" id="macropower-tech">Technology Stack</h2>

> Tools, languages Used.

<table>
  <tr>
    <td align="center" width="96">
      <a href="#firebase">
        <img src="https://cdn.iconscout.com/icon/free/png-256/free-firebase-3628772-3030134.png" width="48" height="48" alt="Firebase" />
      </a>
      <br>Firebase
    </td>
    <td align="center" width="96">
      <a href="#android-studio">
        <img src="https://developer.android.com/static/studio/images/studio-icon.svg" width="48" height="48" alt="Android Studio" />
      </a>
      <br>Android Studio
    </td>
    <td align="center" width="96">
      <a href="#kotlin">
        <img src="https://upload.wikimedia.org/wikipedia/commons/7/74/Kotlin_Icon.png" width="48" height="48" alt="Kotlin" />
      </a>
      <br>Kotlin
    </td>
    <td align="center" width="96">
      <a href="#figma">
        <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/3/33/Figma-logo.svg/1024px-Figma-logo.svg.png" width="48" height="48" alt="Figma" />
      </a>
      <br>Figma
    </td>
    <td align="center" width="96">
      <a href="#google">
        <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Google_%22G%22_logo.svg/1200px-Google_%22G%22_logo.svg.png" width="48" height="48" alt="Google" />
      </a>
      <br>Google
    </td>
  </tr>
</table>

<img src ="https://cdn.pixabay.com/animation/2023/08/21/15/08/15-08-12-734_512.gif" />


## Get Started

To get started with Agri-Energy Connect, follow the [Installation and Setup](#installation-and-setup) and [Building and Running the Prototype](#building-and-running-the-prototype) instructions.

## 🟠 Contributing
We welcome contributions from the community! If you'd like to contribute to Miss Minutes, please follow these steps:
1. Fork the repository.
2. Create a new branch for your changes.
3. Make your changes and commit them with clear commit messages.
4. Push your changes to your forked repository.
5. Open a pull request, and we'll review your changes.

<img src ="https://media.tenor.com/u4RZrIbwcwEAAAAj/pokemon-miltank.gif"/>


## 🟢 Reference List

Bootswatch. [n/d]. Minty [Source code]. 
https://bootswatch.com/minty/
(Accessed 20 April 2024).

Dindi, S. 2023. Create a Hidden Search Bar With HTML, CSS and JavaScript [Source code]. 
https://www.makeuseof.com/search-bar-html-css-javascript/
(Accessed 10 May 2024).

geeks4geeks. 2022. How to add fade-in effect using pure JavaScript ? [Source code]. 
https://www.geeksforgeeks.org/how-to-add-fade-in-effect-using-pure-javascript/
(Accessed 30 May 2024).

stackoverflow. 2017. Send Email Directly From JavaScript using EmailJS [Source code]. 
https://stackoverflow.com/questions/58791656/send-email-directly-from-javascript-using-emailjs
(Accessed 30 May 2024).

W3Schools. 2024. How TO - Fixed Sidebar [Source code]. 
https://www.w3schools.com/howto/howto_css_fixed_sidebar.asp
(Accessed 10 May 2024).

W3Schools. 2024. HTML <input type="date"> [Source code]. 
https://www.w3schools.com/TAGS/att_input_type_date.asp
(Accessed 24 May 2021).
