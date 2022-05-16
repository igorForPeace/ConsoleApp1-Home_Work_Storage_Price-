using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Home_Work_Storage_Price_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Flash a = new Flash();
            //a.Print();
            //a.Load();
            //a.Safe();



            ///// создания списка всех накопителей памяти и тестировка добавления в список новых девайсов
            ///
            //List a = new List(5);
            //Console.WriteLine("Список до добавления: ");
            //Console.WriteLine();
            //a.PrintList();
            //Console.WriteLine("Список после добавления: ");
            //Console.WriteLine();
            //a.AddFlash("King", "Kingstone", "P2");
            //a.AddHDD();
            //a.AddDVD();
            //a.PrintList();


            /////////// тест на удаление хранителей по минимальной цене

            //List a = new List();
            //Console.WriteLine("Список до удаления: ");
            //Console.WriteLine();
            //a.PrintList();
            //a.DeleteByPrice(100);
            //Console.WriteLine("Список после удаления: ");
            //Console.WriteLine();
            //a.PrintList();



            /////////// тест на удаление хранителей по минимальному количеству

            //List a = new List();
            //Console.WriteLine("Список до удаления: ");
            //Console.WriteLine();
            //a.PrintList();
            //a.DeleteByCount(16);
            //Console.WriteLine("Список после удаления: ");
            //Console.WriteLine();
            //a.PrintList();




            ////////  тест на поиск по имени и по минимальной цене

            List a = new List();
            a.PrintList();
            Console.WriteLine();
            a.SearchByName("ProFlashStorage");
            a.SearchByName("Main HDD");
            a.SearchByMinPrice(150);
            a.SearchByMinPrice(1000);

        }
    }
}
