using ConsoleAPIApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPIApp.Utilities
{
    public class API
    {
        /// <summary>
        /// Sends get request to the API
        /// </summary>
        /// <param name="method">Method</param>
        /// <param name="uri">Endpoint</param>
        /// <param name="appId">Username</param>
        /// <param name="developerKey">Password</param>
        /// <returns>Returns the response to the get request</returns>
        public static async System.Threading.Tasks.Task<ResponseModel> sendGetRequest(string method, string uri, string appId, string developerKey)
        {
            // Concatenating API credentials
            method += "?app_id=" + appId + "&app_key=" + developerKey;

            // HttpClient object to connect to specified Web service.
            HttpClient httpClient = new HttpClient();

            // Define the Web API base address
            httpClient.BaseAddress = new Uri(uri);
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            // Getting ready the request to be sent
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, method);

            // Creates the response model to return
            ResponseModel responseModel = new ResponseModel();
            responseModel.action = method;
            try
            {
                // Sending request
                HttpResponseMessage response = await httpClient.SendAsync(request);

                // Assigning response to DTO
                responseModel.APIResponse = await response.Content.ReadAsStringAsync();
                responseModel.statusCode = response.StatusCode.ToString();
            }
            catch (Exception ex)
            {
                // Handles the exception
                responseModel.APIResponse = ex.Message;
                responseModel.statusCode = "500";
            }

            // Returning response
            return responseModel;
        }
    }
}
