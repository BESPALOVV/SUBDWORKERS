using System;

namespace SUBDWORKERS 
{ 
    class Program
{
    static int ValueIsFive(ref string a)
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
                ValueIsFive(ref a);
            }
        }


        int b = Convert.ToInt32(a);
        if (b < 0 || b > 5)
        {
            Console.WriteLine("Выбирите один из пяти вариантов");
            a = Console.ReadLine();
            ValueIsFive(ref a);
        }
        return b;

    }
    static int ValueIsThree(ref string a)
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
                ValueIsThree(ref a);
            }
        }


        int b = Convert.ToInt32(a);
        if (b < 0 || b > 3)
        {
            Console.WriteLine("Выбирите один из трех вариантов");
            a = Console.ReadLine();
            ValueIsThree(ref a);
        }
        return b;

    }
    static string ValueForName(ref string a)
    {
        //string c = "-"; char c1 = Convert.ToChar(c);
        bool marker = true;



        for (int i = 0; i < a.Length; i++)
        {



            if (!Char.IsLetter(a[i]))
            {
                if (a[i] == ' ') { continue; }
                //if (a[i] == '-')
                //{
                //    if (i == 0) { continue; }
                //}
                Console.WriteLine("В значении  могут быть только буквы , пожалуйста укажите значение  заново");
                a = Console.ReadLine();
                ValueForName(ref a);

            }

        }





        return a;

    }
    static int ValueForBirth(ref string a)
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
                Console.WriteLine("В значении  могут быть только цифры , пожалуйста укажите значение  заново");
                a = Console.ReadLine();
                ValueForBirth(ref a);

            }


        }
        int c = Convert.ToInt32(a);
        if (c > 2005 || c < 1923)
        {
            Console.WriteLine("Дата рождения может принимать значение от 1923 года до 2005");
            Console.WriteLine();
            Console.WriteLine("Укажите год рождения заново ");
            a = Console.ReadLine();
            ValueForBirth(ref a);

        }


        int b = Convert.ToInt32(a);


        return b;

    }
    static int ValueIsGood(ref string a)
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
                Console.WriteLine("В значении  могут быть только цифры , пожалуйста укажите значение  заново");
                a = Console.ReadLine();
                ValueIsGood(ref a);
            }
        }


        int b = Convert.ToInt32(a);

        return b;

    }

        static void Main()
        {
            bool[] ArrayWW = new bool[10];
            LongWorkers[] Array = new LongWorkers[10];




            string path = @"C:\Users\Lesh8\Desktop\WorkersData.txt";
            FileStream fl = new FileStream(path, FileMode.OpenOrCreate);
            fl.Close();





            bool marker = true;
            int counter = 0;
            while (marker)
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    for (int i = 0; i < 6 * Array.Length; i++)
                    {
                        string line = sr.ReadLine();
                        if (line == null || line[0] == ' ')
                        {
                            break;
                        }
                        if (line[0] == '%')
                        {
                            ArrayWW[line.Length - 1] = true;
                            Array[line.Length - 1] = new LongWorkers();
                            Array[line.Length - 1].PrintWorker();
                        }
                        if (line[0] == '&')
                        {

                            ArrayWW[line.Length - 1] = true;
                            Array[line.Length - 1] = new LongWorkers(sr.ReadLine(), sr.ReadLine(), Convert.ToInt32(sr.ReadLine()), sr.ReadLine(), sr.ReadLine(), sr.ReadLine());
                            Array[line.Length - 1].PrintWorker();
                        }
                    }



                }

                Console.WriteLine("Внимание Спиок работников ограничен!!!(10 человек)");
                Console.WriteLine();
                Console.WriteLine("1.Добавить работника");
                Console.WriteLine("2.Удалить работника");
                Console.WriteLine("3.Вывести уже имеющегося  работника");
                Console.WriteLine("4.Вывести всех работников");
                Console.WriteLine("5.Завершить работу");
                string Choice = Console.ReadLine();
                Console.Clear();
                switch (ValueIsFive(ref Choice))
                {
                    case 1:
                        {
                            Console.Write("Вы можете занести нового работника в ячейку номер ");
                            for (int i = 0; i < ArrayWW.Length; i++)
                            {
                                if (!ArrayWW[i] == true)
                                {
                                    Console.Write(" " + (i + 1) + " ");
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine("В какую ячейку вы хотите занести работника?");
                            int choice1 = int.Parse(Console.ReadLine());


                            counter++;
                            Console.WriteLine("Как вы хотите добавить работника?");
                            Console.WriteLine("1.Конструктор по умолчанию");
                            Console.WriteLine("2.Скопировать работника ");
                            Console.WriteLine("3.Заполнить данные о работнике вручную");
                            string choice = Console.ReadLine();
                            Console.Clear();
                            switch (ValueIsThree(ref choice))
                            {
                                case 1:
                                    {



                                        Array[counter] = new LongWorkers();
                                        using (StreamWriter stream = new StreamWriter(path, true))
                                        {
                                            for (int i = 0; i < choice1; i++)
                                            {
                                                stream.Write("%");
                                            }
                                            stream.WriteLine();
                                            stream.WriteLine(Array[counter].FirstName);
                                            stream.WriteLine(Array[counter].LastName);
                                            stream.WriteLine(Array[counter].Birth);
                                            stream.WriteLine(Array[counter].GetDateKick());
                                            stream.WriteLine(Array[counter].Reason);
                                            stream.WriteLine(Array[counter].LastPlace);

                                        }

                                        Console.Clear();
                                        Console.WriteLine("Действие было выполненно успешно, консоль очистилась самостоятельно");
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Вы можете скопировать работника номер: ");
                                        for (int i = 0; i < ArrayWW.Length; i++)
                                        {
                                            if (ArrayWW[i] == true)
                                            {
                                                Console.Write(" " + (i + 1) + " ");
                                            }
                                        }
                                        int choice2 = int.Parse(Console.ReadLine());
                                        Array[counter] = new LongWorkers(Array[choice2 - 1]);
                                        using (StreamWriter stream = new StreamWriter(path, true))
                                        {
                                            for (int i = 0; i < choice1; i++)
                                            {
                                                stream.Write("&");
                                            }
                                            stream.WriteLine();
                                            stream.WriteLine(Array[counter].FirstName);
                                            stream.WriteLine(Array[counter].LastName);
                                            stream.WriteLine(Array[counter].Birth);
                                            stream.WriteLine(Array[counter].GetDateKick());
                                            stream.WriteLine(Array[counter].Reason);
                                            stream.WriteLine(Array[counter].LastPlace);

                                        }

                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("Присвойте Имя");
                                        string name = Console.ReadLine();
                                        ValueForName(ref name);
                                        Console.Clear();
                                        Console.WriteLine("Присвойте Фамилию");
                                        string LastName = Console.ReadLine();
                                        ValueForName(ref LastName);
                                        Console.Clear();
                                        Console.WriteLine("Присвойте Год рождения");
                                        string birht = Console.ReadLine();
                                        int Birth = ValueForBirth(ref birht);
                                        Console.Clear();
                                        Console.WriteLine("Присвойте Год увольнения");
                                        string datekick = Console.ReadLine();

                                        Console.Clear();
                                        Console.WriteLine("Присвойте Причину увольнения");
                                        string reason = Console.ReadLine();
                                        ValueForName(ref reason);
                                        Console.Clear();
                                        Console.WriteLine("Присвойте Последнее место работы");
                                        string LastPlace = Console.ReadLine();
                                        ValueForName(ref LastPlace);
                                        Console.Clear();
                                        Array[counter] = new LongWorkers(name, LastName, Birth, datekick, reason, LastPlace);
                                        using (StreamWriter stream = new StreamWriter(path, true))
                                        {
                                            for (int i = 0; i < choice1; i++)
                                            {
                                                stream.Write("&");
                                            }
                                            stream.WriteLine();
                                            stream.WriteLine(Array[counter].FirstName);
                                            stream.WriteLine(Array[counter].LastName);
                                            stream.WriteLine(Array[counter].Birth);
                                            stream.WriteLine(Array[counter].GetDateKick());
                                            stream.WriteLine(Array[counter].Reason);
                                            stream.WriteLine(Array[counter].LastPlace);

                                        }





                                        break;
                                    }
                            }




                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Какого работника вы хотите удалить?");
                            for (int i = 0; i < ArrayWW.Length; i++)
                            {
                                if (ArrayWW[i] == true)
                                {
                                    Console.Write(" " + (i + 1) + " ");
                                }
                            }
                            int choice3 = int.Parse(Console.ReadLine());

                            string[] Alltext = File.ReadAllLines(path);
                            for (int i = 0; i < Alltext.Length; i++)
                            {
                                if (Alltext[i] == null) { break; }
                                string str = Alltext[i];
                                if (str[0] == '%' && str.Length == choice3 || str[0] == '&' && str.Length == choice3)
                                {
                                    for (int j = 0; j < 7; j++)
                                    {
                                        Alltext[i + j] = null;
                                    }
                                }
                            }
                            string[] Alltext1;
                            int counter1 = 0;
                            for (int i = 0; i < Alltext.Length; i++)
                            {

                                if (Alltext[i] != null)
                                {
                                    counter1++;
                                }
                            }
                            Alltext1 = new string[counter1];
                            for (int j = 0; j < Alltext1.Length; j++)
                            {
                                Alltext1[j] = Alltext[j];

                            }

                            File.WriteAllLines(path, Alltext1);
                            Console.Clear();
                            Console.WriteLine("Действие было выполненно успешно, консоль очистилась самостоятельно");

                            break;
                        }
                    case 3:

                        Console.WriteLine("Какого работника вы хотите вывести?");
                        for (int i = 0; i < ArrayWW.Length; i++)
                        {
                            if (ArrayWW[i] == true)
                            {
                                Console.Write(" " + (i + 1) + " ");
                            }
                        }
                        int choice4 = int.Parse(Console.ReadLine());


                        Console.Read();
                        break;










                }










            }









            //using (StreamWriter stream = new StreamWriter(path, true)) 
            //{
            //    stream.WriteLine("Hello, how are you&&");
            //    stream.WriteLine("Hello, how are you&&453453");
            //    stream.WriteLine("Hello, how are you&&4534453453453453");
            //}
            //string ooo;
            //using(StreamReader stream = new StreamReader(path)) 
            //{
            //    ooo= stream.ReadToEnd();

            //}
            //Console.WriteLine( ooo );























            //        Console.WriteLine(  "Выбирите количество работников которое хотите записать");

            //        Workers[] workers = new LongWorkers[5];
            //        for (int i = 0; i < workers.Length; i++)
            //        {
            //            Console.WriteLine("Выбирите вариант создания работника №" + i + ":");

            //            Console.WriteLine("1. Конструктор по умолчанию ");
            //            Console.WriteLine("2. Скопировать работника");
            //            Console.WriteLine("3. Ввести данные работника вручную ");
            //            Console.WriteLine("4. Вывести уже введенных работников");
            //            string gg = Console.ReadLine();
            //            int val = ValueIsGood(ref gg);


            //            switch (val)
            //            {
            //                case 1:
            //                    workers[i] = new Workers();
            //                    workers[i].PrintWorker();
            //                    break;
            //                case 2:
            //                    if (i == 0)
            //                    {
            //                        Console.WriteLine("Выбeрите другой вариант, не сотрудников которых вы могли бы скопировать");
            //                        Console.WriteLine("Выберите вариант 1, если хотите создать по умолчанию и вариант 3 если хотите задать вручную");
            //                        int Vall = int.Parse(Console.ReadLine());
            //                        if (Vall == 1) { goto case 1; }
            //                        if (Vall == 3) { goto case 3; }

            //                    }
            //                    Console.Write("Вы можете скопировать сотрудников номер ");
            //                    for (int j = 0; j < i; j++)
            //                    {
            //                        Console.Write(j + "\t");
            //                    }
            //                    Console.WriteLine();
            //                    Console.WriteLine("Какго сотрудника из уже созданных вы хотите скопировать?");

            //                    int iter = int.Parse(Console.ReadLine());
            //                    while (iter < 0 || iter > i - 1)
            //                    {
            //                        Console.WriteLine("Номер сотрудника выбран неверно, укажите номер заново");
            //                        iter = int.Parse(Console.ReadLine());
            //                    }
            //                    workers[i] = new Workers(workers[iter]);
            //                    workers[i].PrintWorker();

            //                    break;
            //                case 3:
            //                    Console.WriteLine("Присвойте Имя");
            //                    string name = Console.ReadLine();
            //                    ValueForName(ref name);
            //                    Console.WriteLine("Присвойте Фамилию");
            //                    string LastName = Console.ReadLine();
            //                    ValueForName(ref LastName);
            //                    Console.WriteLine("Присвойте дату рождения");
            //                    string birht = Console.ReadLine();
            //                    int Birth = ValueForBirth(ref birht);
            //                    workers[i] = new Workers(name, LastName, Birth);
            //                    break;
            //                case 4:
            //                    for (int z = 0; z < i; z++)
            //                    {
            //                        workers[z].PrintWorker();
            //                        Console.WriteLine();


            //                    }
            //                    Console.WriteLine("Выберите вариант 1, если хотите скопировать выберите варинат 2, если хотите создать по умолчанию и вариант 3 если хотите задать вручную ");
            //                    int Vall1 = int.Parse(Console.ReadLine());
            //                    if (Vall1 == 1) { goto case 1; }
            //                    if (Vall1 == 2) { goto case 2; }
            //                    if (Vall1 == 3) { goto case 3; }

            //                    break;
            //            }


            //        }



            //    }


















        }        //}
    }
}
