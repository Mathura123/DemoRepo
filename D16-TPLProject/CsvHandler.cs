using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;

namespace TPLProject
{
    class CsvHandler
    {
        public static void ImplementCSVDataHandling()
        {
            string importFilePath = @"C:\Users\Mayur\source\repos\D16-TPLProject\Utility\Address.csv";
            string exportFilePath = @"C:\Users\Mayur\source\repos\D16-TPLProject\Utility\Export.csv";

            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Data reading done successfully from Address.csv file");
                foreach (AddressData addressData in records)
                {
                    Console.Write($"\t{addressData.FirstName}");
                    Console.Write($"\t{addressData.LastName}");
                    Console.Write($"\t{addressData.Address}");
                    Console.Write($"\t{addressData.City}");
                    Console.Write($"\t{addressData.State}");
                    Console.Write($"\t{addressData.Code}");
                    Console.Write("\n");
                }

                using (var writer = new StreamWriter(exportFilePath))
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }
            }
        }
        
    }
}
