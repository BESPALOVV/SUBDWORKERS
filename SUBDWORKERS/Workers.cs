using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUBDWORKERS
{
    internal class Workers : IComparable
    {
        protected static string ValueIsLetter(ref string a)
        {
            //string c = "-"; char c1 = Convert.ToChar(c);

            for (int i = 0; i < a.Length; i++)
            {



                if (!Char.IsLetter(a[i]))
                {
                    if (a[i] == ' ')
                    {
                        continue;
                    }

                    Console.WriteLine("В значении  могут быть только буквы, пожалуйста укажите значение  заново");
                    a = Console.ReadLine();
                    ValueIsLetter(ref a);
                }
            }


            return a;

        }
        protected static int ValueIsDigit(ref string a)
        {
            //string c = "-"; char c1 = Convert.ToChar(c);

            for (int i = 0; i < a.Length; i++)
            {



                if (!Char.IsDigit(a[i]))
                {

                    //if (a[i] == '-')
                    //{
                    //    if (i == 0) { continue; }
                    //}
                    Console.WriteLine("В значении  могут быть только цифры, пожалуйста укажите значение  заново");
                    a = Console.ReadLine();
                    ValueIsDigit(ref a);
                }
            }

            int b = Convert.ToInt32(a);
            return b;

        }
        protected static int NoZeroBirth(ref int a)
        {

            if (a <= 0)
            {
                Console.WriteLine("Дата рождения не может быть отрицательной или равной нулю ");
                Console.WriteLine("Введите новую дату рождения ");
                a = int.Parse(Console.ReadLine());
                NoZeroBirth(ref a);
            }
            else
            {
                return a;
            }
            return a;
        }
        public int CompareTo(object a)
        {
            Workers o = a as Workers;
            if (o != null)
            {
                return this.JBirth.CompareTo(o.JBirth);
            }
            else
            {
                throw new Exception("Невозможно сравнить два объекта");
            }
        }
        public Workers()
        {


            Firstname = "Default FirstName";
            Lastname = "Default Lastname";
            JBirth = 99999;

        }
        public Workers(Workers workers)
        {

            this.Firstname = workers.FirstName;
            this.Lastname = workers.LastName;
            this.JBirth = workers.Birth;

        }
        public Workers(string Firstname, string Lastname, int Birth)
        {

            this.Firstname = Firstname;
            this.Lastname = Lastname;
            JBirth = Birth;
        }
        private bool SavedW;



        private string Firstname;

        public string FirstName
        {
            get { return Firstname; }
            set { Firstname = ValueIsLetter(ref value); }
        }
        private string Lastname;

        public string LastName
        {
            get { return Lastname; }
            set { Lastname = ValueIsLetter(ref value); }
        }
        private int JBirth;

        public int Birth
        {
            get { return JBirth; }
            set { JBirth = NoZeroBirth(ref value); }
        }
        public void PrintWorker()
        {

            Console.WriteLine("Имя рабочего: " + Firstname);
            Console.WriteLine("Фамилия рабочего: " + Lastname);
            Console.WriteLine("Год рождения рабочего: " + JBirth);
        }



    }
}

