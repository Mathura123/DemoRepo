using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace TPLProject
{
    class ReadCSV_And_WriteJSON
    {
        public static void ImplementCSVToJSON()
        {
            string importFilePath = @"C:\Users\Mayur\source\repos\D16-TPLProject\Utility\Address.csv";
            string exportFilePath = @"C:\Users\Mayur\source\repos\D16-TPLProject\Utility\AddressDetails.json";

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
                JsonSerializer jsonSerializer = new JsonSerializer();
                using (StreamWriter streamWriter = new StreamWriter(exportFilePath))
                using (JsonWriter writer = new JsonTextWriter(streamWriter))
                {
                    jsonSerializer.Serialize(writer, records);
                }
            }
        }
        public static void ImplementJSONToCSV()
        {
            string jsonFilePath = @"C:\Users\Mayur\source\repos\D16-TPLProject\Utility\AddressDetails.json";
            string csvFilePath = @"C:\Users\Mayur\source\repos\D16-TPLProject\Utility\AddressDetails.csv";

            IList<AddressData> addressDatas = JsonConvert.DeserializeObject<IList<AddressData>>(File.ReadAllText(jsonFilePath));
            using (var writer = new StreamWriter(csvFilePath))
            using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvExport.WriteRecords(addressDatas);
            }
        }
    }
}