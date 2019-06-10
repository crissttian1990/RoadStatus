using ConsoleAPIApp.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPIApp.Repositories
{
    public class RoadRepository
    {
        public void roadStatus(string roadName)
        {
            // Getting connection string and details
            SettingsModel settings = new SettingsModel();

            // Makning API request (GET)
            ResponseModel response = new ResponseModel();
            response = Utilities.API.sendGetRequest(roadName, settings.url, settings.appId, settings.developerKey).Result;

            // Checking if the response status is 200 in order to read road status
            if (response.statusCode.ToLower().Equals("ok"))
            {
                // Declaring variables needed for response
                string status = "";
                string description = "";

                // Read the response and assign values to the object (reading position 0 because it's an array with length 1)
                dynamic x = JArray.Parse(response.APIResponse);
                status = x[0].statusSeverity;
                description = x[0].statusSeverityDescription;

                // Displaying response with road status
                Console.WriteLine("The status of the " + roadName + " is as follows ");
                Console.WriteLine("Road Status: " + status);
                Console.WriteLine("Road Status Description: " + description);
            }
            else
            {
                Console.WriteLine(roadName + " is not a valid road");
            }
        }
    }
}
