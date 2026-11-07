using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10._2
{
    internal class Example
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Dictionary<string, string> re4nik = new Dictionary<string, string>();

            re4nik.Add("window", "прозорец");
            re4nik.Add("door", "врата");
            re4nik.Add("gate", "врата");
            re4nik.Add("room", "стая");

            try
            {
                re4nik.Add("window", "витрина");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key = \"window\" already exists.");
            }

            Console.WriteLine("For key = \"room\", value {0}.", re4nik["room"]);
            re4nik["room"] = "помещение";
            Console.WriteLine("For key = \"room\", value = {0}.", re4nik["room"]);

            re4nik["glass-case"] = "витрина";

            try
            {
                Console.WriteLine("For key = \"bla-bla\", value = {0}.",
                         re4nik["bla-bla"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key = \"bla-bla\" is not found.");
            }

            string value = "";
            if (re4nik.TryGetValue("bla-bla", out value))
            {
                Console.WriteLine("For key = \"bla-bla\", value = {0}.", value);
            }
            else
            {
                Console.WriteLine("Key = \"bla-bla\" is not found.");
            }

            if (!re4nik.ContainsKey("house"))
            {
                re4nik.Add("house", "къща");
                Console.WriteLine("Value added for key = \"house\": {0}",
                    re4nik["house"]);
            }

            Console.WriteLine();
            foreach (KeyValuePair<string, string> kvp in re4nik)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }

            Dictionary<string, string>.ValueCollection valueColl = re4nik.Values;
            Console.WriteLine();
            foreach (string s in valueColl)
            {
                Console.WriteLine("Value = {0}", s);
            }

            Dictionary<string, string>.KeyCollection keyColl = re4nik.Keys; 
            Console.WriteLine();
            foreach (string s in keyColl)
            {
                Console.WriteLine("Key = {0}", s);
            }

            Console.WriteLine("\nRemove(\"glass-case\")");
            re4nik.Remove("glass-case");

            if (!re4nik.ContainsKey("glass-case"))
            {
                Console.WriteLine("Key \"glass-case\" is not found.");
            }
            Console.ReadLine();

        }
    }
}
