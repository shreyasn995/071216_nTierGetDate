using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetDateBusinessLayer;

namespace GetDateClient
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLogic businessLogic = new BusinessLogic();
            System.Console.WriteLine(businessLogic.GetDate());
            System.Console.ReadLine();
        }
    }
}
