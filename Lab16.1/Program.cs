using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace Lab16._1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            Products[] products = new Products[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите код товара");
                int code = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите наименование товара");
                string name = Console.ReadLine();
                Console.WriteLine("Введите стоимость товара");
                double prise = Convert.ToDouble(Console.ReadLine());
                products[i] = new Products() { Code = code, Name = name, Price = prise };
            }

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            string jsonProducts = JsonSerializer.Serialize(products, options);
            string productsJson = "D:/Папка/Product.json";

            //*Проверяем, существует ли файл, если нет, то создаем его

            if (!File.Exists(productsJson))
            {
                File.Create(productsJson);
            }

            //*Записываем в файл json-строку

            using (StreamWriter sw = new StreamWriter(productsJson))
            {
                sw.WriteLine(jsonProducts);
                sw.Close();
            }

            Console.WriteLine(jsonProducts);
            Console.ReadKey();

        }

    }

   



}
