using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Refactoring101
{
    public class QuestionsAndAnswers
    {
        public void Run()
        {
            double max = GetMax(10, 20);
            Console.WriteLine($"Max = {max}");

            PrintPeople();

            var studentService = new StudentService();
            studentService.DisplayStudentCount();

            var date = new CustomDate(2024, 6, 15);
            PrintDate(date);
        }

        // 1. Mysterious Name → Rename
        public double GetMax(double firstNumber, double secondNumber)
        {
            return firstNumber > secondNumber ? firstNumber : secondNumber;
        }

        // 2. Duplicate Code → Extract method already OK, improve naming
        public void PrintPeople()
        {
            PrintNameWithBorder("Mr. Harry Potter");
            PrintNameWithBorder("Ms. Mary Poppin");
            PrintNameWithBorder("Mr. Johny Black");
        }

        private void PrintNameWithBorder(string name)
        {
            const string border = "***********************";
            Console.WriteLine(border);
            Console.WriteLine($"   {name}");
            Console.WriteLine(border);
            Console.WriteLine();
        }

        // 3. Shotgun Surgery → Centralize responsibility
        public class StudentService
        {
            private const int StudentCount = 48;

            public void DisplayStudentCount()
            {
                Console.WriteLine($"Student Count = {StudentCount}");
                Console.WriteLine($"Total Students : {StudentCount}");
            }
        }

        // 4 & 5. Data Clump + Feature Envy → Introduce Date class
        public void PrintDate(CustomDate date)
        {
            Console.WriteLine(date.Format());
        }
    }

    // Feature Envy fixed here
    public class CustomDate
    {
        public int Year { get; }
        public int Month { get; }
        public int Day { get; }

        public CustomDate(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public string Format()
        {
            return $"{Day:D2}/{Month:D2}/{Year:D4}";
        }
    }
}
