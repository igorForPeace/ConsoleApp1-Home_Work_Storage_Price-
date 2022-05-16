using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Home_Work_Storage_Price_
{
    class List 
    {
        static Random rnd = new Random();
        private InformationCarrier[] arr;
        private int countOfDevices;
        public List(int count)
        {
            countOfDevices = count;
            arr = new InformationCarrier[countOfDevices];
            for (int i = 0; i < countOfDevices; i++)
            {
                if (rnd.Next(1, 4) == 1)
                {
                    arr[i] = new Flash();
                }
                else if (rnd.Next(1, 4) == 2)
                {
                    arr[i] = new HDD();
                }
                else arr[i] = new DVD();
            }
        }
        public List() :this(10) { }

        public void PrintList()
        {
            for (int i = 0; i < countOfDevices; i++)
            {
                arr[i].Print();
                Console.WriteLine();
            }
        }

        public void AddFlash(string name, string producer, string model)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[countOfDevices] = new Flash(name, producer, model);
            countOfDevices++;
        }
        public void AddFlash()
        {
            this.AddFlash("ProFlashStorage", "Samsung", "M2");
        }

        public void AddHDD(string name, string producer, string model)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[countOfDevices] = new HDD(name, producer, model);
            countOfDevices++;
        }
        public void AddHDD()
        {
            this.AddHDD("Main HDD", "SeaGate", "Drive1");
        }

        public void AddDVD(string name, string producer, string model)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[countOfDevices] = new DVD(name, producer, model);
            countOfDevices++;
        }
        public void AddDVD()
        {
            this.AddDVD("Simple DVD disc", "San Disc", "DVD-RW");
        }

        public void DeleteByPrice(int MinPrice)  // удаление по минимальной цене
        {
            int new_count = 0;
            for (int i = 0; i < this.countOfDevices; i++)
            {
                if (arr[i].Price>=MinPrice)
                {
                    new_count++;
                }
            }

            InformationCarrier[] newArr = new InformationCarrier[new_count];
            int j = 0;
            for (int i = 0; i < this.countOfDevices; i++)
            {
                if (arr[i].Price >= MinPrice)
                {
                    newArr[j] = arr[i];
                    j++;
                }
            }
            this.countOfDevices = new_count;
            arr = newArr;
        }

        public void DeleteByCount(int MinCount)  // удаление по минимальному количеству утройств
        {
            int new_count = 0;
            for (int i = 0; i < this.countOfDevices; i++)
            {
                if (arr[i].Count >= MinCount)
                {
                    new_count++;
                }
            }

            InformationCarrier[] newArr = new InformationCarrier[new_count];
            int j = 0;
            for (int i = 0; i < this.countOfDevices; i++)
            {
                if (arr[i].Count >= MinCount)
                {
                    newArr[j] = arr[i];
                    j++;
                }
            }
            this.countOfDevices = new_count;
            arr = newArr;
        }


        public void SearchByName(string name)
        {
            int count = 0;
            Console.Write("\nДевайсы с именем " + name);
            for (int i = 0; i < this.countOfDevices; i++)
            {
                
                if (arr[i].Name ==name)
                {
                    Console.WriteLine();
                    arr[i].Print();
                    count++;
                }
                
            }
            if (count == 0) Console.Write(" нет\n");
        }

        public void SearchByMinPrice(int minPrice)
        {
            int count = 0;
            Console.Write("\nДевайсы выше минимальной цены " + minPrice);
            for (int i = 0; i < this.countOfDevices; i++)
            {

                if (arr[i].Price >= minPrice)
                {
                    Console.WriteLine();
                    arr[i].Print();
                    count++;
                }

            }
            if (count == 0) Console.Write(" нет\n");
        }



    }

    
    
}
