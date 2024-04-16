﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._16.Reflection
{
    public class GetTypeExam
    {
        private static void PrintInterfaces(Type type)
        {
            Console.WriteLine("----------Interfaces----------");

            Type[] interfaces = type.GetInterfaces();
            foreach(Type i in interfaces)
                Console.WriteLine("Name:{0}", i.Name);

            Console.WriteLine();
        }

        private static void PrintFields(Type type)
        {
            Console.WriteLine("----------Fields----------");

            FieldInfo[] fields = type.GetFields(
                BindingFlags.NonPublic |
                BindingFlags.Public |
                BindingFlags.Static |
                BindingFlags.Instance
                );
            foreach(FieldInfo field in fields )
            {
                string accessLevel = "protected";
                if (field.IsPublic)
                {
                    accessLevel = "public";
                }
                else if (field.IsPrivate)
                {
                    accessLevel = "private";
                }
                Console.WriteLine("Access:{0}, Type:{1}, Name:{2}", accessLevel, field.FieldType.Name, field.Name);
            }
            Console.WriteLine();
        }

        private static void PrintMethods(Type type)
        {
            Console.WriteLine("----------Methods----------");

            MethodInfo[] methods = type.GetMethods();
            foreach(MethodInfo method in methods )
            {
                Console.WriteLine("Type:{0}, Name:{1}, Parameter:", method.ReturnType.Name, method.Name);
                ParameterInfo[] args = method.GetParameters();
                for (int i = 0; i  < args.Length; i++)
                {
                    Console.WriteLine("{0}", args[i].ParameterType.Name);
                    if (i < args.Length - 1)
                    {
                        Console.WriteLine(", ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void PrintProperties(Type type)
        {
            Console.WriteLine("----------Properties----------");

            PropertyInfo[] properties = type.GetProperties();
            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine("Type:{0}, Name:{1}", property.PropertyType.Name, property.Name);
            }
            Console.WriteLine();
        }

        public void Main()
        {
            int a = 0;
            Type type = a.GetType();

            PrintInterfaces(type);
            PrintFields(type);
            PrintProperties(type);
            PrintMethods(type);
        }
    }
}
