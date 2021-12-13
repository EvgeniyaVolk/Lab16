using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Lab16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите код товара, наименование и стоимость");
            int code=0;
            string name=null;
            double price = 0;
            Products[] products = new Products[5];
            products[0] = new Product_1(name,code,price);
            products[1] = new Product_2(name,code,price);
            products[2] = new Product_3(name,code,price);
            products[3] = new Product_4(name,code,price);
            products[4] = new Product_5(name,code,price);
            for (int i = 0; i < 5; i++)
            {
              string Product=Console.WriteLine(products[i].Code + ". " + products[i].Name + " " + products[i].Price);
            }
           
            Console.ReadKey();

        }
    }
    public abstract class Products
    {
        public abstract int Code { get; set; }
        public abstract string Name { get; set; }
        public abstract double Price { get; set; }
        public Products(string name, int code, double price)
        {
            Code = code;
            Price = price;
            Name = name;
        }

    }
    public class Product_1 : Products
    {
        string name;
        int code;
        double price;
        public Product_1(string name, int code, double price) : base(name, code, price)
        {
        }
        public override string Name
        {
            get 
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                return name;
            }
            set 
            {
                name = value;
            }
        }
        public override int Code
        {
            get
            {
                Console.Write("Code: ");
                int code = Convert.ToInt32(Console.ReadLine());
                return code;
            }
            set 
            {
                code = value;
            }
        }
        public override double Price 
        {
            get
            {
                Console.Write("Price: ");
                double price = Convert.ToInt32(Console.ReadLine());
                return price;
            }
            set
            {
                price = value;
            }
        }

    }
    public class Product_2 : Products
    {
        string name;
        int code;
        double price;
        public Product_2(string name, int code, double price) : base(name, code, price)
        {
        }
        public override string Name
        {
            get
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override int Code
        {
            get
            {
                Console.Write("Code: ");
                int code = Convert.ToInt32(Console.ReadLine());
                return code;
            }
            set
            {
                code = value;
            }
        }
        public override double Price
        {
            get
            {
                Console.Write("Price: ");
                double price = Convert.ToInt32(Console.ReadLine());
                return price;
            }
            set
            {
                price = value;
            }
        }

    }
    public class Product_3 : Products
    {
        string name;
        int code;
        double price;
        public Product_3(string name, int code, double price) : base(name, code, price)
        {
        }
        public override string Name
        {
            get
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override int Code
        {
            get
            {
                Console.Write("Code: ");
                int code = Convert.ToInt32(Console.ReadLine());
                return code;
            }
            set
            {
                code = value;
            }
        }
        public override double Price
        {
            get
            {
                Console.Write("Price: ");
                double price = Convert.ToInt32(Console.ReadLine());
                return price;
            }
            set
            {
                price = value;
            }
        }

    }
    public class Product_4 : Products
    {
        string name;
        int code;
        double price;
        public Product_4(string name, int code, double price) : base(name, code, price)
        {
        }
        public override string Name
        {
            get
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override int Code
        {
            get
            {
                Console.Write("Code: ");
                int code = Convert.ToInt32(Console.ReadLine());
                return code;
            }
            set
            {
                code = value;
            }
        }
        public override double Price
        {
            get
            {
                Console.Write("Price: ");
                double price = Convert.ToInt32(Console.ReadLine());
                return price;
            }
            set
            {
                price = value;
            }
        }

    }
    public class Product_5 : Products
    {
        string name;
        int code;
        double price;
        public Product_5(string name, int code, double price) : base(name, code, price)
        {
        }
        public override string Name
        {
            get
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override int Code
        {
            get
            {
                Console.Write("Code: ");
                int code = Convert.ToInt32(Console.ReadLine());
                return code;
            }
            set
            {
                code = value;
            }
        }
        public override double Price
        {
            get
            {
                Console.Write("Price: ");
                double price = Convert.ToInt32(Console.ReadLine());
                return price;
            }
            set
            {
                price = value;
            }
        }

    }
}





