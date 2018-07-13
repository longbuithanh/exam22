using System;
using entity;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[5];
            products[0] = new Book();
            products[1] = new Book();
            products[2] = new Book();
            products[3] = new Phone();
            products[4] = new Phone();
            
        }
    }
}