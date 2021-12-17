using System;
using System.Collections.Generic;
class Stackpeogram
{
    static void Main(string[] args)
    {
        Stack<string> name = new Stack<string>();
        name.Push("akmal");
        name.Push("ajmal");
        name.Push("shakib");
        name.Push("sharukh");
        name.Push("afsar");
        name.Push("mailk");
        Console.WriteLine("peek element in the list :"+name.Peek()+"\n");
        Console.WriteLine("before pop the list\n");
        foreach (var i in name)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine(" ");
        Console.WriteLine("after pop the list\n");
        Console.WriteLine(name.Pop());
        foreach (var i in name)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
        Console.WriteLine(name.Peek());
    }
    
  }  