using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JSONserialdeserial
{
    class Program
    {
        public static void Main()
        {
            int arrlength = 0;
            bool check = false;
            int[] nums = Array.Empty<int>();
            var rand = new Random();

            Console.Write("Введите кол-во элементов (0 - 200): ");

            while (!check)
            {
                try
                {
                    int test = Convert.ToInt32(Console.ReadLine());
                    if (test >= 201 || test <= 0) throw new IOException(); // проверочка

                    arrlength = test;
                    nums = new int[arrlength];
                    check = true;
                }
                catch (IOException)
                {
                    Console.WriteLine("Введите корректное число элементов!");
                }
            }




            for (int i = 0; i < arrlength; i++)
            {
               nums[i] = rand.Next(201);
            }
            string jsonString = JsonSerializer.Serialize(nums); // Сериализация в JSON и вывод в консоль
            Console.WriteLine(jsonString + " - JSON");
            int[] nums2 = JsonSerializer.Deserialize<int[]>(jsonString); // Десериализация из J
            foreach(int i in nums2)
            {
                Console.Write(i + " ");
            }
            Console.Write("- int[]");
        }

    }
}
