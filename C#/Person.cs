using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp;
/*public class Person
{
    private string name = "";
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}*/

public class Person1
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public Person1(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

public class Person2
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
}

public class Person3
{
    public required string Name { get; init; }
    public required int Age { get; init; }
}

