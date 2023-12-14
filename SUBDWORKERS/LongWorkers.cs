using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUBDWORKERS
{
    internal class LongWorkers : Workers
    {
        public LongWorkers() : base()
        {
            DateKickOut = 99999;
            ReasonKick = "Default Reason";
            LastPlaceJ = "Default LastPlace";


        }
        public LongWorkers(string firstname, string lastname, int birth, string datekick, string reason, string lastplace) : base(firstname, lastname, birth)
        {
            this.SetDateKick(datekick);
            Reason = reason;
            LastPlaceJ = lastplace;
        }
        public LongWorkers(LongWorkers workers) : base(workers)
        {
            Reason = workers.Reason;
            LastPlace = workers.LastPlace;
            SetDateKick(Convert.ToString(workers.GetDateKick()));



        }



        int ValueForKick(ref string a)
        {
            //string c = "-"; char c1 = Convert.ToChar(c);
            bool marker = true;
            for (int i = 0; i < a.Length; i++)
            {



                if (!Char.IsDigit(a[i]))
                {

                    //if (a[i] == '-')
                    //{
                    //    if (i == 0) { continue; }
                    //}
                    Console.WriteLine("В значении  могут быть только цифры , пожалуйста укажите значение  заново");
                    a = Console.ReadLine();
                    ValueForKick(ref a);

                }

            }
            int c = Convert.ToInt32(a);

            if (c != 99999)
            {
                if (c - this.Birth < 16 || c > 2023)
                {

                    Console.WriteLine("Год увольнения не может привышать значение текущего года, также возраст мин оф трудоустр - 16 лет");
                    Console.WriteLine();
                    Console.WriteLine("Укажите год рождения заново ");
                    a = Console.ReadLine();
                    ValueForKick(ref a);

                }
            }

            int b = Convert.ToInt32(a);


            return b;

        }
        private int DateKickOut;
        public void SetDateKick(string a)
        {
            this.DateKickOut = ValueForKick(ref a);
        }
        public int GetDateKick()
        {
            return this.DateKickOut;
        }
        private string ReasonKick;
        public string Reason
        {
            get { return ReasonKick; }
            set { ReasonKick = value; }
        }

        private string LastPlaceJ;

        public string LastPlace
        {
            get { return LastPlaceJ; }
            set { LastPlaceJ = value; }
        }

        public int GetDuration()
        {
            return this.DateKickOut - 2023;
        }
        public int HowLongWork()
        {
            return this.Birth / this.DateKickOut * 100;
        }
        public void PrintWorker()
        {
            base.PrintWorker();
            Console.WriteLine("Дата увольнения рабочего: " + DateKickOut);
            Console.WriteLine("Причина увольнения: " + ReasonKick);
            Console.WriteLine("Последнее место работы:  " + LastPlaceJ);
        }



    }
}

