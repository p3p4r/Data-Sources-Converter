using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    /*
     * Problem: To slow, stuck because timeout 
     * Solution: You can make a derived class, which will set the timeout property of the base WebRequest class
     * link: https://stackoverflow.com/questions/601861/set-timeout-for-webclient-downloadfile/3052637#3052637?newreg=ef3fa6cd3659442291f6fa065b66626b
    */
    public class WebDownload : WebClient
    {
        /// <summary>
        /// Time in milliseconds
        /// </summary>
        public int Timeout { get; set; }

        public WebDownload() : this(60000) { }

        public WebDownload(int timeout)
        {
            this.Timeout = timeout;
        }

        protected override WebRequest GetWebRequest(Uri address)
        {
            var request = base.GetWebRequest(address);
            if (request != null)
            {
                request.Timeout = this.Timeout;
            }
            return request;
        }
    }
}
