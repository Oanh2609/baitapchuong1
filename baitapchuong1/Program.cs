﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapchuong1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào tên của bạn:");
            string name = Console.ReadLine();
            Console.WriteLine("Xin chào"+name);

            Console.ReadKey();
        }
    }
}
