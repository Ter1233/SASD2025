using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp;

public class Examples
{
    public void Run()
    {
        //VarTest();                  // 1
        //StringInterpolation();      // 2
        //var d = GetDistance(3, 4);  // 3
        //TestCollection();           // 4
        //TestPerson();               // 5
        //TestCustomer();             // 6
        //TestDelegate();             // 7
        //ExtensionMethod();          // 8
        //Nullable();                 // 9
    }

    // 1. var
    void VarTest()
    {
        int a = 5;
        string name = "John";
        List<string> list = new List<string>();
    }

    // 2. 
    void StringInterpolation()
    {
        int a = 12345;
        int b = 1234567;
        Console.WriteLine($"a = {a}, b = {b}");
        //Console.WriteLine(string.Format("a = {0}, b = {1}", a, b));

        Console.WriteLine($"Number = |{a}|");
        Console.WriteLine($"Number = |{b}|");
        Console.WriteLine($"Number = |{a,10}|");
        Console.WriteLine($"Number = |{b,10}|");
        Console.WriteLine($"Number = |{a,15:N}|");
        Console.WriteLine($"Number = |{b,15:N}|");
        Console.WriteLine($"Number = |{a,15:N0}|");
        Console.WriteLine($"Number = |{b,15:N0}|");
        Console.WriteLine($"Number = |{a,15:D12}|");
        Console.WriteLine($"Number = |{b,15:D12}|");
    }

    // 3.
    static double GetDistance(double x, double y)
    {
        return Math.Sqrt(x * x + y * y);
    }

    // 4. 
    void TestCollection()
    {
        int[] arr0 = new int[5] { 1, 2, 3, 4, 5 };
        List<int> list0 = new List<int>() { 1, 2, 3, 4, 5 };

        int[] arr1 = new[] { 1, 2, 3, 4, 5 };
        List<int> list1 = new() { 1, 2, 3, 4, 5 };

        var arr2 = new int[] { 1, 2, 3, 4, 5 };
        var list2 = new List<int>() { 1, 2, 3, 4, 5 };

        var arr3 = new[] { 1, 2, 3, 4, 5 };
        var list3 = new List<int> { 1, 2, 3, 4, 5 };

        int[] arr4 = [1, 2, 3, 4, 5];
        List<int> list4 = [1, 2, 3, 4, 5];
    }

    // 5.
    void TestPerson()
    {
        // วิธีที่ 1: Constructor ตั้งค่าให้ทั้งหมด
        var p1 = new Person1("John", 35);

        // วิธีที่ 2: สร้าง object ที่ยังตั้งค่าฟิลด์ไม่ครบ
        // แล้วค่อย set Properties ในภายหลัง
        var p2 = new Person2();
        p2.Name = "John";
        p2.Age = 35;

        // วิธีที่ 3: ใช้ constructor & initializer ร่วมกัน
        var p3 = new Person3()
        {
            Name = "John",
            Age = 35
        };
    }

    // 6.
    void TestCustomer()
    {
        Customer cust = new()
        {
            Name = "John",
            Order = new()
            {
                new() {Name = "Noodle", Price = 40.5m},
                new() {Name = "Potato", Price = 32.0m},
            }
        };
    }

    // 7.
    void TestDelegate()
    {
        new DelegateSample().TestDelegate();
    }

    // 8.
    void ExtensionMethod()
    {
        // เรียกแบบ Utility Method ปกติ
        Console.WriteLine(StringUtil.Half("Hello World, John."));

        // เรียกแบบ Extension Method
        Console.WriteLine("Hello World, John.".Half());
    }

    // 9.
    static void Nullable()
    {
        int? a = null;
        Console.WriteLine(a > 0);  // false
        Console.WriteLine(a <= 0); // false; ข้อควรระวัง null เทียบกับอะไรก็ได้ false
        Console.WriteLine(a ?? 9999); // ถ้า a เป็น null จะให้ค่า 9999 ออกมา
        a ??= 5; // ถ้า a เป็น null ให้ a มีค่าเท่ากับ 5
        int b = (int)a; // ต้อง explicit casting เป็น (int) ก่อนใช้ในรูป int
    }
}
