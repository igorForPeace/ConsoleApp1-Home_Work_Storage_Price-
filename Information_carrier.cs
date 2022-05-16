using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Home_Work_Storage_Price_
{
    abstract class InformationCarrier
    {
        private string name;
        private string producer;
        private string model;
        private int count;
        private int price;
        
        public InformationCarrier(string name, string producer, string model, int count, int price)
        {
            this.name = name;
            this.producer = producer;
            this.model = model;
            this.count = count;
            this.price = price;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Producer
        {
            get { return producer; }
            set { producer = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public abstract void Print();
        public abstract void Safe();
        public abstract void Load();
    }
}
