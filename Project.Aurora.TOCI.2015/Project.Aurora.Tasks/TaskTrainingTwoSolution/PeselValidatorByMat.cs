using Project.Aurora.TOCI._2015.YourWork.TaskTrainingTwo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Aurora.Tasks.TaskTrainingTwoSolution
{
    public class PeselValidatorByMat : PeselValidator
    {
        private DateObjectForPeselValidator date = new DateObjectForPeselValidator();
        public override string GetNick()
        {
            return "Mateo";
        }

        public override bool IsPeselValid(string pesel)
        {
            //check if proper format
            if (int.TryParse(pesel, out _) == false || pesel.Length != 11) return false; // TODO "_" discard???
            //checksum
            if (Checksum(pesel) == false) return false;



            
            throw new NotImplementedException(); 
        }

        protected override bool Checksum(string pesel)
        {
            //wagi 1 3 7 9 1 3 7 9 1 3 7 pesel ma 11 cyfr ale ostatnia jest kontrolna i cheksume robimy na 10 a ostatnia jest wynikiem kontrolnym7, 
            if(pesel.Length != 11 )
            {
                return false;
            }
            int[] weightArray = {1, 3, 7, 9, 1, 3, 7, 9, 1, 3}; //wagi
            int controlNumber = pesel[10]; // pobierz cyfre kontrolna
            var peselWithoutLastDigitArray = pesel.ToCharArray(0, 10);
            //suma kontrolna
            int controlSum = 0;
            for (int i = 0; i < pesel.Length; i++)
            {
                controlSum += pesel[i] * weightArray[i];
            }
            controlSum = controlSum % 10;
            return controlSum == controlNumber; //TODO - otestowac jak bedziemy odpowiednio madrzy

        }
        //metoda ktora wrzuca wartosci do date
        protected override string CutOffDate(string pesel)//to ma zostawic sama reszte bez daty?
        {
            date.year = Convert.ToInt32("pesel[0]" + "pesel[1]");//91081101232
            date.month = Convert.ToInt32("pesel[0]" + "pesel[1]");//91081101232
            date.day = Convert.ToInt32("pesel[0]" + "pesel[1]");//91081101232
            return "";//czy data na poczatku jest poprawna
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            //1. sprawdz czy rok przestepny,
            //2. czy miesiac jest pomiedzy 1 a 12
            //2.do okreslenia liczby dni stworz tablice ilosci dni dla posczegolnych miesiecy i wprowadz odpowiednie warunki dla dni
            throw new NotImplementedException(); 
        }
    }
}
