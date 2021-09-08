# Weather Browser

This .Net Core web browser allows users to know the current temperature and weather description of a city. There are different jpeg files saved to the root folder which display an image based on the current weather description. If a user enters an invalid city name, the website returns an error message while continuing to allow city searches. 

## Implementation
The website receves weather inforamtion through OpenWeatherMap API. Our page fetches the city name from the text input form on the home page and error page. A http request passes on information from the API to a class object. The class object is what we use to get the current temperature and description.

## Home Page
<img width="1680" alt="Screen Shot 2021-09-07 at 4 02 42 PM" src="https://user-images.githubusercontent.com/27907086/132430467-dadb861d-dd8b-4f79-960f-70441b96f76f.png">

## Example Searches
<img width="1680" alt="Screen Shot 2021-09-07 at 4 03 42 PM" src="https://github.com/eolt/.NetCore_Projects/files/7125084/Screenshot_h.pdf">

<img width="1680" alt="Screen Shot 2021-09-07 at 4 03 42 PM" src="https://user-images.githubusercontent.com/27907086/132430570-a9b1f9d5-0099-4ae0-9842-e29cdd109566.png">

<img width="1680" alt="Screen Shot 2021-09-07 at 4 04 12 PM" src="https://user-images.githubusercontent.com/27907086/132430597-547402f9-6d7b-4993-82df-f04af377d7cf.png">

## Error Page
<img width="1680" alt="Screen Shot 2021-09-07 at 4 04 46 PM" src="https://user-images.githubusercontent.com/27907086/132430381-2e4e4ea7-51cf-4ff7-b616-d49d457933bb.png">



## TODOs
- Store website to a Docker container and deploy to a cloud server
- Implement program to automatically get the location of the computer browser and display the info. 


