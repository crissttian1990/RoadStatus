# How was built
This console app was written in c# using .NET framework.

The project contains:

Models
Settings model file (to store the credentials) and response model file (to store the json response and http status).

Utilities
API class, where the get method to call the API is stored.

RoadRepository
It's the file where is stored the main method that calls the API and returns the display, it also returns true or false depending if the call was successful or not.

Program.cs
It contais the declaration of RoadRepository and calls the method passing the first parameter (see example below). The method in RoadRepository is in charge of displaying the data. At the end of this method includes Console.ReadLine() instruction for not closing the window until the user press a random key.


# Output

Execute on powershell:

PS C:\> .\RoadStatus.exe A2

Output:

The status of the A2 is as follows

Road Status is Good

Road Status Description is No Exceptional Delays

Press any key to exit...


Execute on powershell:

PS C:\> .\RoadStatus.exe A233

Output:

A233 is not a valid road

Press any key to exit...

# Set up credentials
Update the values on the app.config file.

# Unit tests
In the unit tests the credentials must be included inside the method getCredentials() in order to run the tests correctly. Once these are set up, you can right click on the test explorer and run both tests, if the credentials are valid you will get 2 red ticks.
