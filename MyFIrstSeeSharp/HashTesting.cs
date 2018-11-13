using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFIrstSeeSharp
{
    namespace DataStructures
    {
        class Student
        {
            private string name { get; set; }
            private int grade { get; set; }
        }
        class HashTesting
        {
            public HashTesting() { }
            public Dictionary<int, Student> mapBuilder(int[] key,Student[] students)
            {
                Dictionary<int, Student> map = new Dictionary<int, Student>();
                for (int i = 0; i < key.Length; i++)
                {
                    foreach (Student it in students)
                    {
                        students[key[i]] = it;
                    }
                }
                return map;
            }
            public void addToMap(Dictionary<int,Student> dict,int key,Student value)
            {
                dict.Add(key, value);
            }
        }
    }
}
