using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число факториал каторого нужно вычислить");
            int f =Convert.ToInt32( Console.ReadLine());

            //int res = GetFactorialAsync(f).Result;
            GetFactorialAsync(f);
            GetFactorialAsync(f);
            //Console.WriteLine($"Факториал обычный = {GetFactorial(f)}");
            
            
            Console.WriteLine("Main закончил");
            Console.ReadKey();
        }

        static int GetFactorial(int f)
        {
            int res = 1;
            if(f == 0) {
                return 1;
            }
            else {
                for(int i = 1; i <= f; i++) {
                    res = res * i;
                    Console.WriteLine(res);
                }
            }
            return res;
        }
        static async Task<int> GetFactorialAsync(int f)
        {
            Console.WriteLine("GetFactorialAsync запустился");
            int res = await Task.Run(() => GetFactorial(f));
            Console.WriteLine($"GetFactorialAsync отработал = {f}");
            return res;
        }
    }
}
