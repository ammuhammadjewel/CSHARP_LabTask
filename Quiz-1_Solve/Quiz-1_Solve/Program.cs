using System;
namespace Quiz1_solve
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Welcome to c# quiz";
            //Console.WriteLine(a);
            callFunction1(ref a, out int b);
            Console.WriteLine(a);

            void callFunction1(ref string x, out int y)
            {
                y = x.Length;
                string a = " for fall semester";
                string b = " for mid-term 2022";
                string c = "I'm from c#";

                int d = y;
                callFunction2(ref x);
                callFunction3(out y, c);
                Console.Write(y);
                Console.Write("-{0}-", y = 1);
                Console.WriteLine(b[b.Length - 1] + "" + b[b.Length - 2]);
                if (d == a.Length && d == b.Length)
                {
                    x += a;
                }
                else
                    x += b;
                void callFunction2(ref string p)
                {
                    Console.WriteLine(p);
                }
                void callFunction3(out int q, string r)
                {
                    q = r.Length;
                }
            }
        }
    }
}