# Micro Center Website Revamp


# 1. Project Overview, Introduction and Requirements specification

The redesign of Micro Center's website in December 2008 introduced a new layout – the search bar, store location drop-down menu, shortcuts to the shopping cart, and user account functions located in the header; product advertisements in the body; and additional product advertisements stacked vertically on either side of the body, with the expanded navigation bar found above the advertisements in the left column. The website was last redesigned in July 2014, bringing forth a new look that we still see today. Regardless, the website's familiar layout remains primarily unchanged from what was introduced in the 2008 redesign. While there have been some minor updates to design elements since then, the UI and graphics remain largely inoffensive. This is not objectionable as they still do serve their purpose, which is just that – to remain inoffensive so as to not distract from the online shopping experience that customers are familiar with. However, the website needs an update. UX elements, for example, already have a presence throughout the website, but they are too far and too few. A solution may be to increase their use and variety, which can be used to invoke an emotional response in users that leads to a boost in sales and overall customer satisfactory ratings. Another solution may be to implement features that facilitate the buying process so customers are able to purchase their items more quickly. Such solutions to a problem – the website needing an update – are what I want to achieve with this project. I want Micro Center's website to have a modern online shopping experience that reflects today's standard of UI and UX, and to share that experience with all of Micro Center's customers.


## 1.1. Introduction

My name is Raphael Mangubat. I am a student in my fourth and final semester at Dunwoody College of Technology located in Minneapolis, Minnesota. The purpose of this project's development is to showcase – and demonstrate application of – the skills and competencies acquired over a two-year duration in studying web development & database programming. In addition, this project fulfills requirements for the following courses: Advanced Topics (CWEB2135), Business Applications (CWEB2011), and Database Systems (CWEB2121).


## 1.2. Project Overview

The primary goals of this project are updating Micro Center's current website UI with a clean, friendlier experience and improving upon functions such as user sign-in and payment options. The new website will be redesigned using a mobile-first approach, prioritizing user-friendliness with smaller devices as technology is still becoming increasingly portable in nature. The UI will also be updated with modern design elements that reflect today's graphics standards. Most pre-existing features such as payment and order processing, shopping cart, and user account operations will be retained. Of these features, improvements will be made to payment processing by adding various other methods of payment for users to choose from during the checkout process. In addition, user account operations will be improved by offering additional SSO options.

- Update UI
	- Mobile-first approach
- Retain pre-existing features
	- Payment & order processing
	- Shopping Cart
	- User account operations
		- Google SSO
- Improve pre-existing features
	- Payment & order processing (payment options)
		- Apple Pay
		- PayPal
		- Google Wallet
	- User account operations
		- Apple SSO
		- Facebook SSO


## 1.3. Project Scope
### 1.3.1 Features the project _must_ implement
#### 1.3.1.1 __Project__ focused features
- Project must use a database (not hard coded values within html code)
- Project must demonstrate the use of a configuration file outside of the code (an application.ini file or web.config)
- Project must use a secure algorithm to hash the password (either system default or one of the modern hashing algorithms with salt like bcrypt or SHA-512/224 - DO NOT USE md5 or SHA-1 or 2)
- Project must use parameterized queries [NO concatenated strings for queries]
- Project must encrypt user sensitive data [using a secure algorithm for encryption like AES or blowfish/twofish]
- Project should function in a hosted environment
- Project code should be in a github or other online repository


#### 1.3.1.2 __Product__ focused features
- Project must be designed using a mobile-first approach.
- Project must have a modernized UI.
- Project must retain most of the website's pre-existing features.
- Project must implement the necessary systems and technologies to diversify user sign-in options.
- Project must implement the necessary systems and technologies to diversify user payment options.
- Project must have a portal for website administrators to manage products and product information.


### 1.3.2 Features the project _should_ implement
- Project should use a color palette that is familiar to customers.
- Project should offer users the ability to switch between light and dark interface themes.
- Project should allow users to change their account email.
- Project should allow users to change their account password.


### 1.3.3 Features the project _could_ implement
- Project could request user for their location.
- Project could get user's time zone to automatically switch between light and dark interface themes.
- Project could utilize cookies to customize guest users' shopping experience.


### 1.3.4 Features the project _will not_ implement
- Project will not replace the original website.
- Project will not send emails to users.
- Project will not allow users to purchase, return, or exchange real products in exchange for real currency.


## 1.4. Project Requirements
ID | Status | Priority | User Story | Estimated Difficulty | Acceptance Criteria
:-: | :-- | :-: | :-- | :-: | :--
&nbsp; | Backlog<br>In progress<br>Done | A – high priority<br>D – low priority | &nbsp; | 1 – easy<br>100 – hard | &nbsp;
x | Backlog<br>In progress<br>Done |  | As a customer, I want to be able to create an account. | diff | Function is pre-existing and will be carried over into redesign.
x | Backlog<br>In progress<br>Done |  | As a customer, I want to be able to connect an account from another service to quickly log in. | diff | The login screen will display multiple sign in options when users are logged out.
x | Backlog<br>In progress<br>Done |  | As a customer, I want to be able to manage my account. | diff | When logged in, a link to the account settings page can be found under the username displayed in the header, or within the navigation menu if viewed on mobile.
x | Backlog<br>In progress<br>Done |  | As a customer, I want to be able to delete my account. | diff | An option to delete the user account can be found at the bottom of the account settings page.
x | Backlog<br>In progress<br>Done |  | As a customer, I want to be able to change my account email. | diff | User email can be changed in the account settings page.
x | Backlog<br>In progress<br>Done |  | As a customer, I want to be able to change my account password. | diff | Account password can be changed in the account settings page.
x | Backlog<br>In progress<br>Done |  | As a customer, I want to be able to view products by filter parameters. | diff | When viewing products, filters can be found in the left column, or directly under the header when viewed on mobile.
x | Backlog<br>In progress<br>Done |  | As a customer, I want to be able to pay by using other services. | diff | Multiple different payment options will be displayed during the payment section of the checkout process.
x | Backlog<br>In progress<br>Done |  | As an administrator, I want to be able to manage product inventory. | diff | An admin area is available when visiting the admin portal website.
 

## 1.5. Definitions, Acronyms, and Abbreviations used in documentation
 - AES
 - bcrypt
 - Hash
 - Hashing algorithm
 - IP address
 - MD5
 - Salt
 - SHA
 - UX
 - UI


---


# 2. Analysis
## 2.1. Description of Problem
 - minimal diversity of payment options
 - little to no animations with interactions
 - only one method of SSO (Google)

## 2.2. Technologies Used
 - POSSIBLE
	- Weglot (website translator) ?
	- Canva (graphics) ?
	- (icons) ?
	- GitKraken Boards
	- coolors.co (for site palette/color theme)
	- Origami (wireframes)
	- Visio (diagrams)
 - stripe (payment platform)
 - Square .NET SDK (payment platform)
 - Braintree GraphQL API (payment platform)
 - Auth0 (SSO)


 - CERTAIN
	- HTML CSS JS JQUERY C# MVC
	- Github (repository)
	- Github Student Pack
	- Bootstrap 4
	- Bootswatch: Flatly (Bootstrap theme)


## 2.3. System Architecture



## 2.4. Use Case Diagrams and Descriptions



## 2.5. (additional sections for any other mockups and diagrams available)



---


# 3. Design
## 3.1. Architecture design 



## 3.2. Interface design



## 3.3. Source Code



## 3.4. Data Model and Storage



## 3.5. Security Considerations
