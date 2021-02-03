using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Aurora.TOCI._2015.YourWork.TaskTrainingThreeBankTransfers
{
    public class BankTransfer
    {
        public string DestinationBank { get; set; }

        public string SourceBank { get; set; }

        public bool IsTransferSuccessful { get; set; }
        public string BankCode { get; set; }
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
        public string ClientName { get; set; }


    }
}
