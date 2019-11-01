using System;

namespace BasicExceptionHandling {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Let's try and catch");

/*            Console.Write("Enter a nbr:  ");
            String nbrStr = Console.ReadLine();
            int nbr = GetNbr(nbrStr);
            Console.WriteLine("nbr = " + nbr);
*/
            Console.WriteLine("test optional params...");
            Console.WriteLine("test 1 - provide 1...");
            PrintThreeStrings("Sean");
            Console.WriteLine("test 2 - provide 2...");
            PrintThreeStrings("Sean", s3:"Stinks");

            int n1 = 0;
            Console.Write("Enter a number n1: ");
            string n1Str = Console.ReadLine();
            try {
                n1 = Convert.ToInt32(n1Str);
            }
            catch (FormatException fe) {
                Console.WriteLine("Format Exception: " + fe.ToString());
            }
            Console.WriteLine("n1 = " + n1);
            Console.WriteLine("Bye");
        }

        internal static int GetNbr(string nbrStr) {
            return Convert.ToInt32(nbrStr);
        }

        // s1 is required, s2 is optional
        private static void PrintThreeStrings(string name, string s2 = "really", string s3 = "rocks") {
            Console.WriteLine("3 strings:  " + name + " " + s2 + " " + s3);
        }
    }
}
