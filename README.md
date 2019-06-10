# RoadStatus

# How was built


# Output
Execute on powershell:
PS C:\&gt; .\RoadStatus.exe A2
Output:
The status of the A2 is as follows
Road Status is Good
Road Status Description is No Exceptional Delays
Press any key to exit...

Execute on powershell:
PS C:\&gt; .\RoadStatus.exe A233
Output:
A233 is not a valid road
Press any key to exit...

# Set up credentials
Update the values on the app.config file.

# Unit tests
In the unit tests the credentials must be included inside the method getCredentials() in order to run the tests correctly. Once these are set up, you can right click on the test explorer and run both tests, if the credentials are valid you will get 2 red ticks.
