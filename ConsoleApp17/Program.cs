using System;
using System.Diagnostics;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            Person p = new Person();
            Console.WriteLine(p.IntDateOfBirth);
            p.IntDateOfBirth = 20140820;
            Console.WriteLine(p.IntDateOfBirth);
            Console.WriteLine(p.Name);
            Magazine m = new Magazine();
            Console.WriteLine(m.ToString());*/

            Magazine journal = new Magazine();

            Console.WriteLine(journal.ToShortString());
            Console.WriteLine(journal[Frequency.Weekly]);
            Console.WriteLine(journal[Frequency.Monthly]);
            Console.WriteLine(journal[Frequency.Yearly]);
            Console.WriteLine();
            journal.Name = "Эрудит";
            journal.Frequn = Frequency.Weekly;

            journal.Exitdate= new DateTime(2014,08,20);
            journal.Tirage = 10;
            Person prsn = new Person("Редакция этого журнала", "-", DateTime.Parse("01/01/2000"));
            Article articl = new Article(prsn, "Необычный элемент журнала", 5.0);
            journal.AddArticles(articl);
            Console.WriteLine(journal.ToString());
            journal.Articles.Clear();
            Console.WriteLine(journal.ToString());

            Console.WriteLine("Сравнение времени работы");
            Stopwatch sw = new Stopwatch();

            sw.Start();
            Article[] myArr = new Article[1110000];
            for (int i = 0;i < myArr.Length; i++) {myArr[i] = new Article();}
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            sw.Restart();
            Article[][] myArrr = new Article[3][];
            myArrr[0] = new Article[10000];
            myArrr[1] = new Article[100000];
            myArrr[2] = new Article[1000000];
            for (int i = 0; i < 10000; i++) { myArrr[0][i] = new Article(); }
            for (int i = 0; i < 100000; i++) { myArrr[1][i] = new Article(); }
            for (int i = 0; i < 1000000; i++) { myArrr[2][i] = new Article(); }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            sw.Restart();
            Article[,] myArrrr = new Article[10, 111000];
            for (int i = 0; i < 10; i++) { for (int j = 0; j < 111000; j++) { myArrrr[i,j] = new Article(); } }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
