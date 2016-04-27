using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Web;
using WhoOffBot.Api.WhosOff;

namespace WhoOffBot.Logic
{
    public class WhosOff
    {
        private string apiKey = "";
		private string apiUrl = "https://publicapi.whosoff.com/WhosOffPublic.asmx?WSDL";
        private WhosOffPublicSoapClient client = new WhosOffPublicSoapClient();
        public int DaysOffLeftThisYear(string userEmail)
        {
            var yearEnd = new DateTime(DateTime.UtcNow.Year, 12, 31);
            var result = client.WHOSOFF_BY_STAFFID(apiKey, DateTime.UtcNow.ToString("d/MM/yyyy"), yearEnd.ToString("d/MM/yyyy"), userEmail);
            //extract data from XMl response.
            return (10);
        }

        internal XElement GetStaffId(string userEmail)
        {
            var staffId = "";
            var staffDetails = client.STAFF_DETAILS1(apiKey);
            var staffNodes = staffDetails.Descendants("DATA").Elements();
            foreach(var staffNode in staffNodes.Elements())
            {
                if(staffNode.Name == "Staff_Email_Address" && staffNode.Value == userEmail)
                {
                    return (staffNode.Parent);
                }
            }
            return (null);
        }
    }
}