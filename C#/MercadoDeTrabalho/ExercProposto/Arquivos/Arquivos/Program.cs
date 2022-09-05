using System;
using System.IO;
using System.Globalization;
using Arquivos.Entities;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\c#\MercadoDeTrabalho\ExercProposto\compras.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                string sourceFolderpath = Path.GetDirectoryName(sourcePath);
                string targetFolderPath = sourceFolderpath + @"\out";
                string targetPath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sr = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int unit = int.Parse(fields[2]);

                        Product product = new Product(name, price, unit);

                        sr.WriteLine(product.Name + "," + product.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }  
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
