using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBBillCalculation
{
    public class EBDetail
    {
        private static int s_meterId = 1001;

        public string EbId {get;}

        public string UserName {get; set;}

        public long Phone {get; set;}

        public string MailId {get; set;}

        public int Units {get; set;}

        public EBDetail(string userName, long phone, string mailID, int units)
        {
            s_meterId++;
            
            EbId = "EB" + s_meterId;
            UserName = userName;
            Phone = phone;
            MailId = mailID;
            Units = units;
        }

    }
}