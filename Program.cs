using System;

namespace FluentApiDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var fluent = new Fluent();

            foreach (var data in fluent.DataList)
            {
                Console.WriteLine(data);   
            }
        }
    }
}