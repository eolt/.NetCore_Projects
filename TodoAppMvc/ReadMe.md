# 7 Day Event Planner 

This program acts as a normal todo list with the additional setup of listing events for the span of one week. A user can navigate through each day of week and find the task(s) due for that day. The program uses SQLite and Entity Framework packages to enable saving data to memory. And implement MVC (model view controller) format to organize the data, functionality, and UI of our app. 

![navigate](https://user-images.githubusercontent.com/27907086/133369878-88aacb3d-de70-4e52-848d-3e4046cf52fa.gif)


## Home Page Display 
Our web app updates the navigation bar based on the current day of observation. The current day of week will be on the right hand side and extend towards left for rest of the seven days. 

<img width="1680" alt="Screen Shot 2021-09-13 at 9 42 33 PM" src="https://user-images.githubusercontent.com/27907086/133362499-143903ee-a00a-44ec-93a1-e5f1e523fbd5.png">

<img width="1680" alt="Screen Shot 2021-09-14 at 9 47 25 PM" src="https://user-images.githubusercontent.com/27907086/133362527-758b814f-f076-43d6-8e24-991caf6524d5.png">

<img width="1680" alt="Screen Shot 2021-09-16 at 9 49 30 PM" src="https://user-images.githubusercontent.com/27907086/133362541-e89a0c4e-5b18-4c47-8bde-239f729f8f7a.png">


## Events Display

<img width="1680" alt="Screen Shot 2021-09-13 at 8 58 32 PM" src="https://user-images.githubusercontent.com/27907086/133365540-b35a4ee7-c93f-4298-9b58-e07e7d3c3657.png">


## Create/Edit Event Display
The creation button is accessed at the top of navigation bar.  

The user has the option to set a description to the event and highlight event with a specific color. Due date, time, and title of event are required to submit the input. 
<img width="1680" alt="Screen Shot 2021-09-13 at 8 44 30 PM" src="https://user-images.githubusercontent.com/27907086/133362933-d1b62e41-7cbb-4b83-abcc-58563cd7eac2.png">

The edit page is similar to create, except previous values of event are included. 
<img width="1680" alt="Untitled" src="https://user-images.githubusercontent.com/27907086/133363204-14f2af18-c31f-4ada-9e29-92c96da3afa4.png">

## Details 
When a user clicks on one of the events, a details page is returned. The details page lists the Information of event and shows actions to perform.

<img width="1680" alt="Screen Shot 2021-09-13 at 9 45 04 PM" src="https://user-images.githubusercontent.com/27907086/133365185-e12b8460-c08c-4eb9-a4aa-74b53f523829.png">




