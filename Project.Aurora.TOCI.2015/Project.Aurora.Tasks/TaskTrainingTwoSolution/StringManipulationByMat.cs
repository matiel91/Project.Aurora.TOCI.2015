using Project.Aurora.TOCI._2015.YourWork.TaskTrainingTwo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Aurora.Tasks.TaskTrainingTwoSolution
{
    public class StringManipulationByMat : GhostRiderStringManipulationsBase
    {
        public override StringManipulationsResults RunStringOperations(string subject, string seek)
        {
            throw new NotImplementedException();
        }

        protected override string GetNick()
        {
            return "Mateo";
        }

        protected override bool IsStringAnagramOfString(string subject, string seek)
        {
            foreach (var item in seek)
            {
                if (subject.Contains(item))
                {
                    subject.Remove(subject.IndexOf(item));
                }
                else return false;
            }
            return subject.Length == 0 ? true:false;
        }

        protected override bool IsStringElementsInString(string subject, string seek)
        {
            foreach (var item in seek)
            {
                if (subject.Contains(item))
                {
                    subject.Remove(subject.IndexOf(item));
                }
                else return false;
            } 
            return true;
        }

        protected override bool IsStringInString(string subject, string seek)
        {
            return subject.Contains(seek);
        }
    }
}
