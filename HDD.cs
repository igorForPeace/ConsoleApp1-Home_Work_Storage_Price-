using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Home_Work_Storage_Price_
{
    class HDD : InformationCarrier
    {
        private int storageCapacity;
        private int usbSpeed;
        public HDD(string name, string producer, string model, int count, int price, int capacity, int speed)
            : base(name, producer, model, count, price)
        {
            storageCapacity = capacity;
            usbSpeed = speed;
        }
        public HDD() : this("Main HDD", "SeaGate", "Drive1", 20, 155, 1000, 300) { }
        public HDD(string name, string producer, string model) : this(name, producer, model, 15, 160, 750, 350) { }
        public int StorageCapacity
        {
            get { return storageCapacity; }
            set { storageCapacity = value; }
        }
        public int USBSpeed
        {
            get { return usbSpeed; }
            set { usbSpeed = value; }
        }
        public override void Print()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("Information about HDD: ");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Prodecer: " + Producer);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Count of devices: " + Count);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Capacity: " + StorageCapacity);
            Console.WriteLine("USB Speed: " + USBSpeed);
            Console.WriteLine("=======================");
        }
        public override void Safe()
        {
            Console.WriteLine("HDD " + Name + " safe information.");
        }
        public override void Load()
        {
            Console.WriteLine("HDD " + Name + " load information.");
        }
    }
   
}
