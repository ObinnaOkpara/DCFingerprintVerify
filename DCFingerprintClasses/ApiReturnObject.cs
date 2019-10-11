using System;
using System.Collections.Generic;
using System.Text;

namespace DCFingerprintClasses
{
    /// <summary>
    /// Object to be returned by API calls
    /// </summary>
    /// <typeparam name="T">Object Type</typeparam>
    public class ApiReturnObject<T>
    {
        /// <summary>
        /// Status of the request.
        /// </summary>
        public bool Status { get; set; }
        /// <summary>
        /// Description of the status.
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Request content. 
        /// </summary>
        public T Object { get; set; }
    }
}
