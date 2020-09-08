using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Serialization_
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonFileName = "Xiaomi.txt";
            Xiaomi i = new Xiaomi
            {
                calling = "Xiaomi: Please answer the phone",
                camera = "Xiaomi: Smile, I am taking a picture",
                messaging = "Xiaomi: You have a message",
                touch_ID = "Xiaomi: Please leave your fingerprint",
                music = "Xiaomi: For listening music turn it on",
            };
            SaveAsJsonFormat(i, jsonFileName);
            Console.ReadLine(); 



        }
        static void SaveAsJsonFormat(object objGraph, string fileName)
        {
            string jsonString = JsonSerializer.Serialize(objGraph);
            File.WriteAllText(fileName, jsonString);

            Console.WriteLine();
            Console.WriteLine("=> Saved Xiaomi in JSON format!");
        }


        static void PrintXiaomi(Xiaomi x)
        {
            if (x == null) return;

            Console.WriteLine();
            Console.WriteLine("***** Print Smartphone type *****");
            Console.WriteLine($" calling: {x.calling}");
            Console.WriteLine($" camera: {x.camera}");
            Console.WriteLine($" messaging: {x.messaging}");
            Console.WriteLine($" touch_ID: {x.touch_ID}");
            Console.WriteLine($" music: {x.music}");
        }

    }
}
      