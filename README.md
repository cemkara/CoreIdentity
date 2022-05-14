It is a simple membership application made using Microsoft.AspNetCore.Identity.


There are pages that users can access or not access depending on their sign-up page, login page, profile information page and authorization.


Pages:
Home page
AdminArticle list
Article list
my profile


Roles:
admin
User


All users who log in to the "home page" and "my profile" pages can access it.


User with "Admin" role can access "AdminArticle" and "Article" pages


The user whose role is "User" can only access the "Article" page. Sees "Access Denied" error when trying to access "Admin Article" page
