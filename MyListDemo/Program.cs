using MyListDemo;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("örnek");
            Console.WriteLine(list.Count);

            MyListDemo<string> demo = new MyListDemo<string>();
            demo.Add("deneme1");
            Console.WriteLine(demo.Count);

            
        }
    }

    


}