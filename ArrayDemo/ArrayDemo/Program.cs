using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayDemo {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Arrays!");
            ArrayList strings = new ArrayList();
            strings.Add("Hello");
            strings.Add("World");

            foreach (string s in strings) {
                Console.WriteLine(s);
            }

            List<int> nbrs = new List<int>();
            nbrs.Add(5);
            nbrs.Add(7);
            nbrs.Remove(5);


        }
    }

}
