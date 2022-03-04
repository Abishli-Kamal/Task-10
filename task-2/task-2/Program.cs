using System;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "Kamal", "Malik", "Tural", "Baxsheli", "Islam", "Bahadur" };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length>5)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
