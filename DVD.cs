using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Home_Work_Storage_Price_
{
    class DVD : InformationCarrier
    {
        private int readSpeed;
        private int writeSpeed;
        public DVD(string name, string producer, string model, int count, int price, int rspeed, int wspeed)
            :base(name, producer, model, count, price)
        {
            readSpeed = rspeed;
            writeSpeed = wspeed;
        }
        public DVD() :this("Simple DVD disc" , "San Disc" , "DVD-RW" , 15, 25, 100, 150) { }
        public DVD(string name, string producer, string model) : this(name, producer, model, 20, 15, 100, 150 ) { }
        public int ReadSpeed
        {
            get { return readSpeed; }
            set { readSpeed = value; }
        }
        public int WriteSpeed
        {
            get { return writeSpeed; }
            set { writeSpeed = value; }
        }
        public override void Print()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("Information about DVD: ");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Prodecer: " + Producer);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Count of devices: " + Count);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Write speed: " + WriteSpeed);
            Console.WriteLine("Read speed: " + ReadSpeed);
            Console.WriteLine("=======================");
        }
        public override void Safe()
        {
            Console.WriteLine("DVD disc " + Name + " safe information.");
        }
        public override void Load()
        {
            Console.WriteLine("DVD disc " + Name + " load information.");
        }
    }
}
