# Weather WebAPI Service ASP-DOT-NET


1. Receive a latitude/longitude from the user (you can use your own location longitude/latitude information).
2. Find out the city based on the IP (you can use any external API to do so). 
3. Return the weather for the city (using any external weather API)

## API Configuration
1. #### Find out the city with external API. [Link](http://api.ipinfodb.com/v3/ip-city/?key=b7d840505f6bc036c504b5c3fa2589468a8172f8318d664952cf83797a5e8251&format=json)

-  #### You Can use your own API Key If my expires. 

- http://api.ipinfodb.com/v3/ip-city/?key=b7d840505f6bc036c504b5c3fa2589468a8172f8318d664952cf83797a5e8251&format=json


2. #### Return the weather for the city with external weather API [Link](http://api.openweathermap.org/data/2.5/weather?lat=24.904300&lon=67.081700&units=metric&appid=4b9be5067751c7c24283cf32d28bc06b)

-  #### You Can use your own API Key If my expires. 

- http://api.openweathermap.org/data/2.5/weather?lat=24.904300&lon=67.081700&units=metric&appid=4b9be5067751c7c24283cf32d28bc06b


- The application should be an API to be called and should return all the information (city name, weather details). 
Your test will be evaluated on the basis of, API correctness, C# programming knowledge, third-party API integration, and best practices.
We will test the API endpoint using Postman, please use valid names for the endpoints and the data to be uploaded.

# How To Run The Program

1. Load project in visual studio code.
2. Run the Project, It automatically redirects to the URL which contains my latitude and longitude information. https://localhost:44374/api/getweather/lat=24.904300&lon=67.081700
3. Open link in Postman, Which Return the Json Response

## Postman Output 
![picture](output.png)
