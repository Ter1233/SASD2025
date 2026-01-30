using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp;

public class Customer
{
    public required string Name { get; init; }
    public string? Address { get; init; } = null;
    public int? Age { get; init; } = null;
    public required List<Product> Order { get; init; }
}
public class Product
{
    public required string Name { get; init; }
    public required decimal Price { get; init; }
}
