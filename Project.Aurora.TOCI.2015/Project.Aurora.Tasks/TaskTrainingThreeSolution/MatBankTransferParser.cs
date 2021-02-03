using Project.Aurora.TOCI._2015.YourWork.TaskTrainingThreeBankTransfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Aurora.Tasks.TaskTrainingThreeSolution
{
    public class MatBankTransferParser : BankTransfersParser
    {
        private List<string> ListOfImportedEntries { get; set; }
        public List<BankTransfer> BankTransfersList { get; set; } = new List<BankTransfer>();
        MatFileOperation fileOperation = new MatFileOperation();
        const string PathToBankTransfersLog = "@\\..\\..\\..\\..\\Project.Aurora.Tasks\\TaskTrainingThreeSolution\\Files\\randomdata4.csv";
        const char SeparatorChar = '|';
        public override List<BankTransfer> GetBankTransfers()
        {
            fileOperation.GetFileContent(PathToBankTransfersLog);
            ListOfImportedEntries =  fileOperation.CutTheStringByNewLine(fileOperation.FileContent);
            foreach (var item in ListOfImportedEntries)
            {
            if (item.Contains(SeparatorChar)) BankTransfersList.Add(GetTransferEntry(item));                            
            }
            return BankTransfersList;
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            BankTransfer bankTransferEntry = new BankTransfer();
            string[] splitedEntry = entry.Split(SeparatorChar);
            bankTransferEntry.SourceBank = splitedEntry[1];
            bankTransferEntry.DestinationBank = splitedEntry[3];
            return bankTransferEntry;
            ///podzielic linijke stringa na poszczegolne czesci i wrzucic w BankTransfer
        }
    }
}
