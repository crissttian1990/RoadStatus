using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPIApp.Model
{
    /// <summary>
    /// Response Model
    /// </summary>
    public class ResponseModel
    {
        /// <summary>
        /// Method name
        /// </summary>
        public string action { get; set; }

        /// <summary>
        /// Status code
        /// </summary>
        public string statusCode { get; set; }

        /// <summary>
        /// API Response
        /// </summary>
        public string APIResponse { get; set; }

        /// <summary>
        /// Response (object type)
        /// </summary>
        public object response { get; set; }
    }
}
