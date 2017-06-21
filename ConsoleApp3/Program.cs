using ConsoleApp3.Data;
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new DataContext())
            {
                ctx.Database.EnsureCreated();
            }
        }
    }
}