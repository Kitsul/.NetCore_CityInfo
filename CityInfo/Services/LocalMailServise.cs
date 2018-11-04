using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Services
{
    public class LocalMailServise : IMailServise
    {
        private string _mailTo = "lightblok@gmail.com";
        private string _mailFrom = "materials.kitsyl@gmail.com";

        public void Send(string subject, string message)
        {
            Debug.WriteLine($"Mail from { _mailFrom } to { _mailTo }, with LocalMailService");
            Debug.WriteLine($"Subject: { subject }");
            Debug.WriteLine($"Message: { message }");
        }
    }
}
