# Personal Schedule 
A simple web browser application to create, read, update, and delete personal tasks/events. Navigate throught events using the "Today", "Tommorrow", or "Later" pages. And create, delete, and edit tasks by clicking the specific UI buttons.   

## Implementation 
The program implements SQL Server as its database to handle saving personal tasks inputted by user. Our .NET Core framework performs the execution of passing information to our databse with the use of migrations, specified in the Migrations folder. 

The Pages folder carrys all the Razor Pages which create the front-end and backend of our web application. The divded sections "Today", "Tomorrow" and "Later" are in their own directory for better accessibility of both developer and the user. 

Each "Day" Razor page has shared html and creation page but uses its own Model when handling Edits or Deletes.   

Using SQL commands we can display the events seamlessly and organized by time of due date. 

## Create Event Form
![Create_1](https://user-images.githubusercontent.com/27907086/128760637-5e34032d-1098-4861-859c-f36f3ce8884a.PNG)

## Display Schedules
![Animation](https://user-images.githubusercontent.com/27907086/128761646-ff152da4-2cf5-48c0-8025-09ae83be8ed9.gif)

## Edit Event In Schedule 
![Edit_Animation](https://user-images.githubusercontent.com/27907086/128760795-a0e1d285-acc5-42ce-a642-c72f494ddf7c.gif)

## Delete Event In Schedule 
![Delete_Animation](https://user-images.githubusercontent.com/27907086/128760800-2e86f6f8-1ff4-4ce1-bd5a-6cdb1e6bd49e.gif)
