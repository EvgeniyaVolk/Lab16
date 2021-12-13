using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Products[] products = new Products[5];

            for (int i = 0; i < 5; i++)

            {
                products[i] = new Products();
               
                Console.Write("Код товара {0}", products[i].Code);
                Console.Write("Название товара {0}", products[i].Name);
                Console.WriteLine("Цена товара {0}", products[i].Price);
            }
            Console.ReadKey();

        }

    }

    public class Products

    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }



        public int GetCode
         {
             get
             {
                 Console.Write("Code: ");
                 int code = Convert.ToInt32(Console.ReadLine());
                 code = Code;
                 return Code;
             }
             set
             {
                 Code = value;
             }
         }
         public string GetName
         {
             get
             {
                 Console.Write("Name: ");
                 string name = Console.ReadLine();
                 name = Name;
                 return Name;
             }
             set
             {
                 Name = value;
             }
         }
         public double GetPrice
         {
             get
             {
                 Console.Write("Price: ");
                 double price = Convert.ToInt32(Console.ReadLine());
                 price = Price;
                 return Price;
             }
             set
             {
                 Price = value;
             }
         }

    }



}
