using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp;

public class DelegateSample
{
    delegate void MyDelegate(string name);
    public void TestDelegate()
    {
        // Function Pointer 1
        MyDelegate func1 = Greeting; // assignment
        func1("John"); // calling

        // Function Pointer 2
        Action<string> func2 = Greeting; // assignment
        func2("Mary"); // calling
    }

    private void Greeting(string name)
    {
        Console.WriteLine("Greeting, World. " + name);
    }
}
