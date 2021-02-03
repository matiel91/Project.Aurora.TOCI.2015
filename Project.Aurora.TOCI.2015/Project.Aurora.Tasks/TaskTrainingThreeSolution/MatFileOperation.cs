using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Aurora.TOCI._2015.YourWork.TaskTrainingThreeBankTransfers;

namespace Project.Aurora.Tasks.TaskTrainingThreeSolution
{
    public class MatFileOperation : FileOperation
    {
        public string FileContent { get; set; }
        public override string GetFileContent(string path)
        {
            FileContent = System.IO.File.ReadAllText(path);
            return FileContent;
        }

       public static void GetCurentCatalog()
        {
            Debug.WriteLine(Environment.CommandLine);
        }

        public List<string> CutTheStringByNewLine(string fileContent)
        {

            var result = fileContent.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None).ToList();
            result.RemoveAt(0);
            return result;

        }
    }
}
