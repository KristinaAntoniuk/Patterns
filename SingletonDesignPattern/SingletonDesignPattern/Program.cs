﻿using System;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton fromTeacher = Singleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
            Console.ReadLine();
        }
    }
}
