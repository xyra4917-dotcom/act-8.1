using System;
using System.Collections;

class Act8_1
{
    static void Main()
    {
        Hashtable records = new Hashtable();
        string choice = "";

        while (choice != "4")
        {
            Console.WriteLine("[1] Add Data");
            Console.WriteLine("[2] Delete Data");
            Console.WriteLine("[3] Display Data");
            Console.WriteLine("[4] End");
            Console.Write("Choose: ");
            choice = Console.ReadLine().Trim();

            if (choice == "1")
            {
                Console.Write("\tEnter Key: ");
                string key = Console.ReadLine().Trim();
                if (key == "")
                {
                    Console.WriteLine("Key cannot be empty!");
                    continue;
                }
                if (records.ContainsKey(key))
                {
                    Console.WriteLine("Key already exists! Duplicate keys are not allowed.");
                    continue;
                }
                Console.Write("\tEnter Value: ");
                string value = Console.ReadLine();
                records.Add(key, value);
                Console.WriteLine("Data added.");
            }
            else if (choice == "2")
            {
                if (records.Count == 0)
                {
                    Console.WriteLine("No data to delete.");
                    continue;
                }
                Console.Write("\tEnter Key to delete: ");
                string key = Console.ReadLine().Trim();
                if (records.ContainsKey(key))
                {
                    records.Remove(key);
                    Console.WriteLine("Data deleted.");
                }
                else
                {
                    Console.WriteLine("Key does not exist!");
                }
            }
            else if (choice == "3")
            {
                if (records.Count == 0)
                {
                    Console.WriteLine("No data to display.");
                    continue;
                }
                Console.WriteLine("\t-Key-\t-Value-");
                foreach (DictionaryEntry i in records)
                    Console.WriteLine($"\t{i.Key}\t{i.Value}");
            }
            else if (choice == "4")
            {
                Console.WriteLine("Thank you.");
            }
            else
            {
                Console.WriteLine("Invalid choice! Please enter 1-4.");
            }
        }
    }
}
