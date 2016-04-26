using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WhoOffBot.Api.WhosOff;

namespace WhoOffBot.Logic
{
    public class WhosOff
    {
        private string apiKey = "";
		private string apiUrl = "https://publicapi.whosoff.com/WhosOffPublic.asmx?WSDL";
        private WhosOffPublicSoapClient client = new WhosOffPublicSoapClient();
        public int DaysOffLeftThisYear(int userId)
        {
            var yearEnd = new DateTime(DateTime.UtcNow.Year, 12, 31);
            var result = client.WHOSOFF_BY_STAFFID(apiKey, DateTime.UtcNow.ToString("DD/MM/YYYY"), yearEnd.ToString("DD/MM/YYYY"), "22");
            //extract data from XMl response.
            return (10);
        }

        internal void GetStaffId(string id)
        {
            var staffDetails = client.STAFF_DETAILS1(apiKey);
            
        }
    }
}