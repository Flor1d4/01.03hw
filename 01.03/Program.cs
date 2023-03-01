using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    class Play
    {

        private string name;
        private string author;
        private string genre;
        private int year;
        private bool disposed=false;
        public Play(string name, string author, string genre, int year)
        {
            this.name = name;
            this.author = author;
            this.genre = genre;
            this.year = year;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }     
        public void Print()
        {
            Console.WriteLine("...Объект cоздан...");
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Автор: " + author);
            Console.WriteLine("Жанр: " + genre);
            Console.WriteLine("Год выпуска: " + year);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {

                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        ~Play()
        {
            Dispose(false);
            Console.WriteLine("...Объект удален...");
        }
    }
    class Shop
    {
        private string name;
        private string adress;
        private string type;
        private bool disposed = false;
        public Shop(string name, string adress, string type)
        {
            this.name = name;
            this.adress = adress;
            this.type = type;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public void Print()
        {
            Console.WriteLine("...Объект cоздан...");
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Адресс: "+adress);
            Console.WriteLine("Тип: "+type);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {

                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        ~Shop()
        {
            Dispose(false);
            Console.WriteLine("...Объект удален...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#1");
            Play play = new Play("Гамлет", "Уильям Шекспир", "Трагедия", 1603);
            play.Print();       
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("\n#2");
            Shop shop = new Shop("Копейка", "вулиця Маршала Малиновського, 27А, Одеса", "Продуктовый");
            shop.Print();       
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
