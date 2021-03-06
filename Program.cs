using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.IO;

namespace H7
{
    class Program
    {
        
        static void Main(string[] args)
        {

            try
            {
                var PhoneBook = new Dictionary<string, string>();
                using (StreamReader sr = new StreamReader(@"D:\phones.txt"))
                using (StreamWriter sw = new StreamWriter(@"D:\new.txt"))
                {

                    //TASK 1
                    string text = sr.ReadToEnd();
                    string[] word = text.Split(new char[] { ' ' });
                    string[] Persons = new string[9];
                    string[] Phones = new string[9];
                    int a = 0, b = 0;
                   
                    for (int i = 1; i < 18; i = i + 2)
                    {
                        Phones[a] = word[i];
                        a = a + 1;
                    }
                    for (int i = 0; i < 18; i = i + 2)
                    {
                        Persons[b] = word[i];
                        b = b + 1;
                    }
                    for (int i = 0; i < 9; i++)
                    {
                        PhoneBook.Add(Persons[i], Phones[i]);
                        
                    }



                    //TASK 2
                    Console.WriteLine("Enter name");
                    string name = Convert.ToString(Console.ReadLine());
                    if (PhoneBook.ContainsKey(name))
                    {
                        PhoneBook.TryGetValue(name, out string val);
                        Console.WriteLine($"Number: {val} ");
                    }
                    else
                    {
                        Console.WriteLine("This name is not in the PhoneBook");
                    }



                    //TASK 3
                        foreach (var f1 in PhoneBook.Values)
                    {
                        if (f1.Contains('+'))
                            Console.WriteLine("");
                        else
                            sw.WriteLine($"+38{f1}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
