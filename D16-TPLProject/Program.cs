using System;

namespace TPLProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CSV Reader");
            CsvHandler.ImplementCSVDataHandling();
            ReadCSV_And_WriteJSON.ImplementCSVToJSON();
            ReadCSV_And_WriteJSON.ImplementJSONToCSV();
        }
    }
}
