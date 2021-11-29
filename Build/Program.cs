using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiBuilding multi = new MultiBuilding("Восточная,31",250,400,35,16);
            multi.Print();
            Console.ReadKey();
        }
    }
    class Building
    {
        string adress;
        double leight;
        double width;
        double heigth;
        public string Adress
        {
            set
            {
                adress = value;
            }
            get
            {
                return adress;
            }
        }
        public double Leigth
        {
            set
            {
                if (value > 0)
                {
                    leight = value;
                }
                else
                {
                    Console.WriteLine("Длина здания не может быть отрицательной или равной нулю.");
                }
            }
            get
            {
                return leight;
            }
        }
        public double Width
        {
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Ширина здания не может быть отрицательной или равной нулю.");
                }
            }
            get
            {
                return width;
            }
        }
        public double Heigth
        {
            set
            {
                if (value > 0)
                {
                    heigth = value;
                }
                else
                {
                    Console.WriteLine("Высота здания не может быть отрицательной или равной нулю.");
                }
            }
            get
            {
                return heigth;
            }
        }
        public Building(string adress, double leigth, double width, double heigth)
        {
            Adress = adress;
            Leigth = leigth;
            Width = width;
            Heigth = heigth;
        }
        public void Print()
        {
            Console.WriteLine("Адрес здания: {0}", adress);
            Console.WriteLine("Длина: {0} м", leight);
            Console.WriteLine("Ширина: {0} м", width);
            Console.WriteLine("Высота: {0} м", heigth );
        }
    }
    sealed class MultiBuilding:Building
    {
        int levels;
        public int Levels
        {
            set
            {
                if (value>0)
                {
                    levels = value;
                }
                else
                {
                    Console.WriteLine("Этажность здания не может быть отрицательной или равной нулю.");
                }
            }
            get
            {
                return levels;
            }
        }
        public  MultiBuilding(string adress, double leigth, double width, double heigth, int levels):base(adress,leigth,width,heigth)
        {
            Levels = levels;
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine("Этажность: {0} этажей", levels);
        }
    }
}

