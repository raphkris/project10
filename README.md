# Micro Center Website Revamp


# 1. Project Overview, Introduction and Requirements specification

The redesign of Micro Center's website in December 2008 introduced a new layout – the search bar, store location drop-down menu, shortcuts to the shopping cart, and user account functions located in the header; product advertisements in the body; and other product advertisements stacked vertically on either side of the body, with the expanded navigation bar found above the advertisements in the left column. The website was last redesigned in July 2014, bringing forth a new look that we still see today. Regardless, the website's familiar layout remains primarily unchanged since the 2008 redesign. While there have been some minor updates to design elements since then, the UI and graphics remain mostly inoffensive. This is not objectionable as they still serve their purpose, which is just that – to remain inoffensive to not distract from the online shopping experience that customers are familiar with. However, the website needs an update. UX elements, for example, already have a presence throughout the website, but they are too far and too few. A solution may be to increase their use and variety to invoke an emotional response in users, leading to a boost in sales and overall customer satisfaction ratings. Another solution may be to implement features that facilitate the buying process so that customers can purchase their items more quickly. Such solutions to a problem – the website needing an update – are what I want to achieve with this project. I want Micro Center's website to have a modern online shopping experience that reflects today's UI and UX standards and to share that experience with all of Micro Center's customers.


## 1.1. Introduction

My name is Raphael Mangubat. I am a student in my fourth and final semester at Dunwoody College of Technology, located in Minneapolis, Minnesota. The purpose of this project's development is to showcase – and demonstrate the application of – the skills and competencies acquired over a two-year duration in studying web development & database programming. Also, this project fulfills requirements for the following courses: Advanced Topics (CWEB2135), Business Applications (CWEB2011), and Database Systems (CWEB2121).


## 1.2. Project Overview

This project's primary goals are updating Micro Center's current website UI with a clean, friendlier experience and improving upon functions such as user sign-in and payment options. The new website will be redesigned using a mobile-first approach, prioritizing user-friendliness with smaller devices as technology is still becoming increasingly portable. The UI will also be updated with modern design elements that reflect today's graphics standards. Most pre-existing features, such as payment and order processing, shopping cart, and user account operations, will be retained. Of these features, improvements will be made to the payment processing by adding various other payment methods for users to choose from during the checkout process. Also, user account operations will be improved by offering additional SSO options.

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


#### 1.3.1.2 __Product__ focused features
- Project must be designed using a mobile-first approach.
- Project must have a modernized UI.
- Project must retain most of the website's pre-existing features.
- Project must implement the necessary systems and technologies to diversify user sign-in options.
- Project must implement the necessary systems and technologies to diversify user payment options.
- Project must have a portal for website administrators to manage products and product information.


### 1.3.2 Features the project _should_ implement
#### 1.3.2.1 __Project__ focused features
- Project should function in a hosted environment
- Project code should be in a github or other online repository

#### 1.3.2.2 __Product__ focused features
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
1 | In progress | A | As a customer, I want to be able to create an account. | 2 | Function is pre-existing and will be carried over into redesign.
2 | In progress | A | As a customer, I want to be able to connect an account from another service to quickly log in. | 55 | The login screen will display multiple sign in options when users are logged out.
3 | In progress | A | As a customer, I want to be able to manage my account. | 3 | When logged in, a link to the account settings page can be found under the username displayed in the header, or within the navigation menu if viewed on mobile.
4 | In progress | B | As a customer, I want to be able to delete my account. | 8 | An option to delete the user account can be found at the bottom of the account settings page.
5 | In progress | B | As a customer, I want to be able to change my account email. | 8 | User email can be changed in the account settings page.
6 | In progress | B | As a customer, I want to be able to change my account password. | 13 | Account password can be changed in the account settings page.
7 | In progress | C | As a customer, I want to be able to view products by filter parameters. | 21 | When viewing products, filters can be found in the left column, or directly under the header when viewed on mobile.
8 | In progress | A | As a customer, I want to be able to pay by using other services. | 55 | Multiple different payment options will be displayed during the payment section of the checkout process.
9 | In progress | A | As an administrator, I want to be able to manage product inventory. | 13 | An admin area is available when visiting the admin portal website.
 

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
 - SSO


---


# 2. Analysis
## 2.1. Description of Problem
 - minimal diversity of payment options
 - little to no animations with interactions
 - only one method of SSO (Google)

## 2.2. Technologies Used
- POSSIBLE
	- stripe (payment platform)
	- Square .NET SDK (payment platform)
	- Braintree GraphQL API (payment platform)
	- Auth0 (SSO)

- CERTAIN
	- LANGUAGES
		- HTML
		- CSS
		- JS
		- C#
	- FRAMEWORKS
		- JQUERY
		- MVC
		- Bootstrap 4
	- SERVICES
		- Github (for repository)
		- Github Student Pack
	- PROGRAMS
		- Visual Studio
		- VSCODE
		- draw.io (diagrams)
		- Microsoft Word
	- HOSTING
		- namecheap (domain)


## 2.3. System Architecture



## 2.4. Use Case Diagrams and Descriptions
(diagrams in draw.io)

CREATE ACCOUNT Use Case | &nbsp;
--: | :--
Name: | Create Account
Actor: | Guest
Description: | Describes the process used to create an account.
Successful completion: | 1. Guest navigates to "Account" log in page.<br>2. Guest navigates to "Create account" page.<br>3. Guest completes account registration form.<br>4. Account registration is confirmed with the guest.
Alternative: | 1. Guest navigates to "Account" log in page.<br>2. Guest navigates to "Create account" page.<br>3. Guest completes account registration form.<br>4. Guest is notified "A registered account is already associated with that email."<br>5. Prompt Guest to navigate to "Reset password" page.
Precondition: | Guest wants to create an account.
Postcondition: | Guest has a user account associated with the ecommerce website.
Assumptions: | 1. Guest is not logged in to an ecommerce account.<br>2. Guest wants to create an account associated with the ecommerce website.<br>3. Guest does not want to use SSO to log in to the ecommerce website.

SSO Use Case | &nbsp;
--: | :--
Name: | SSO
Actor: | Guest
Description: | Describes the process used to log in to the ecommerce website using SSO.
Successful completion: | 1. Guest navigates to "Account" log in page.<br>2. Guest selects one of the SSO methods listed near the log in form.<br>3. Guest follows prompts appropriate for their SSO of choice.<br>4. Guest is redirected to the home page.
Precondition: | Guest wants to log in to the ecommerce website using SSO.
Postcondition: | Guest is logged in to the ecommerce website.
Assumptions: | 1. Guest has an existing account with one or more of the SSO methods offered.<br>2. Guest is not logged in to an ecommerce account.

MANAGE ACCOUNT Use Case | &nbsp;
--: | :--
Name: | Manage Account
Actor: | Registered User
Description: | Describes the process used to manage a user's account.
Successful completion: | 1. Registered User selects "Account" link located in navigation menu.<br>2. Registered User selects "Manage Account" link.
Precondition: | Registered User wants to manage their account data and account preferences.
Postcondition: | Registered User is directed to a page that displays user account operations.
Assumptions: | Registered User is currently logged in using an account associated with the ecommerce website or any one of the SSO services.

DELETE ACCOUNT Use Case | &nbsp;
--: | :--
Name: | Delete Account
Actor: | Registered User
Description: | Describes the process used to delete a user's account.
Successful completion: | 1. Registered User selects "Account" link located in navigation menu.<br>2. Registered User selects "Manage Account" link.<br>3. Registered User selects "Delete Account".<br>4. Confirmation modal of account operation is displayed.<br>5. Registered User selects "Confirm".
Precondition: | Registered User wants to delete their account associated with the ecommerce website.
Postcondition: | 1. Registered User's account is deleted.<br>2. User no longer has a registered account associated with the ecommerce website.
Assumptions: | Registered user is currently logged in using an account associated with the ecommerce website.

UPDATE ACCOUNT EMAIL Use Case | &nbsp;
--: | :--
Name: | Update Account Email
Actor: | Registered User
Description: | Describes the process used to update the email address associated with a user's account.
Successful completion: | 1. Registered User selects "Account" link located in navigation menu.<br>2. Registered User selects "Manage Account" link.<br>3. Registered User selects "Update Email" option.<br>4. Registered User fills in email text box.<br>5. Registered User selects "Update email" button.<br>6. "Email successfully updated." modal is displayed.
Precondition: | Registered User wants to update the email address associated with their ecommerce website account.
Postcondition: | Registered User's account email address is updated.
Assumptions: | Registered User is currently logged in using an account associated with the ecommerce website.

UPDATE ACCOUNT PASSWORD Use Case | &nbsp;
--: | :--
Name: | Update Account Password
Actor: | Registered User
Description: | Describes the process used to update the password associated with a user's account.
Successful completion: | 1. Registered User selects "Account" link located in navigation menu.<br>2. Registered User selects "Manage Account" link.<br>3. Registered User selects "Change password" option.<br>4. Registered User completes the password update form.<br>5. "Password successfully changed." modal is displayed.
Alternative: | 1. Registered User selects "Account" link located in navigation menu.<br>2. Registered User selects "Manage Account" link.<br>3. Registered User selects "Change password" option.<br>4. Registered User completes the password update form.<br>5. "Password does not meet the requirements." modal is displayed.
Precondition: | Registered User wants to update the password associated with their ecommerce website account.
Postcondition: | Registered User's account password is updated.
Assumptions: | Registered user is currently logged in using an account associated with the ecommerce website.

FILTER PRODUCTS Use Case | &nbsp;
--: | :--
Name: | 
Actors: | Guest, Registered User
Description: | Describes the process used to filter products by parameter when browsing items for sale.
Successful completion: | 1. User selects parameters in the side bar to apply filters of their choice.
Precondition: | User wants to filter products by parameter.
Postcondition: | Products are filtered by user selected parameters.
Assumptions: | User is currently browsing products page.

PAYMENT METHODS Use Case | &nbsp;
--: | :--
Name: | Filter Products
Actor: | Registered User
Description: | Describes the process used to select between different payment methods during checkout.
Successful completion: | 1. Registered User selects one of the alternative payment methods listed near the payment information form.<br>2. Registered User completes the instructions necessary for the selected payment method.
Precondition: | Registered User wants to select a different method of payment.
Postcondition: | Registered User is using an alternative payment method.
Assumptions: | 1. Registered User is currently logged in using an account associated with the ecommerce website or any one of the SSO services.<br>2. Registered User is currently in the payment step of the checkout process.

MANAGE INVENTORY Use Case | &nbsp;
--: | :--
Name: | Manage Inventory
Actor: | Administrator
Description: | Describes the process used to manage inventory.
Successful completion: | 1. Administrator navigates to Admin log in page.<br>2. Administrator logs in to the Admin dashboard.
Precondition: | Administrator wants to manage inventory items.
Postcondition: | Administrator manages inventory items through the Admin dashboard.
Assumptions: | User has an existing Administrator account.

## 2.5. (additional sections for any other mockups and diagrams available)



---


# 3. Design
## 3.1. Architecture design 



## 3.2. Interface design



## 3.3. Source Code



## 3.4. Data Model and Storage



## 3.5. Security Considerations
