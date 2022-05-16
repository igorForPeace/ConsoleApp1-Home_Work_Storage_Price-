using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Home_Work_Storage_Price_
{
    class Flash : InformationCarrier
    {
        private int storageCapacity;
        private int usbSpeed;

        public Flash(string name, string producer, string model, int count, int price, int capacity, int speed) : 
            base (name, producer, model, count, price)
        {
            storageCapacity = capacity;
            usbSpeed = speed;
        }
        public Flash() : this("ProFlashStorage" , "Samsung", "M2", 10, 350, 512, 900) { }
        public Flash(string name, string producer, string model) : this( name, producer, model, 10, 350, 512, 900) { }
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
            Console.WriteLine("Information about Flash card: ");
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
            Console.WriteLine("Flash card "+ Name + " safe information.");
        }
        public override void Load()
        {
            Console.WriteLine("Flass card " + Name + " load information.");
        }

    }
}
