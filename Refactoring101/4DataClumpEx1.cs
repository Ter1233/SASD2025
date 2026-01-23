using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring101.DataClump1;

// 4.1
public class DataClump1
{
    public void Print(string name, string address, int age)
    {
        // ...
    }
    
public class Customer
    {
        public required string Name { get; set; }
        public required string Address { get; set; }
        public required int Age { get; set; }
    }

