using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public static class ListExtension
    {
        public static IEnumerable<T> WhereIs<T>(this IEnumerable<T> list, Func<T, bool> predicate)
        {
            foreach(var item in list)
            {
                if (predicate(item))
                {
                    yield return item;
                }              
            }
        }
    }
    class Program
    {
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>
            {
                new Student {Name = "Phuoc", Age = 25},
                new Student {Name = "Thao", Age = 22},
                new Student {Name = "ABC", Age = 15}

            };
            IEnumerable<Student> LonHon20 = list.WhereIs(stu => stu.Age > 20);

            Console.ReadLine();
        }
    }
}
