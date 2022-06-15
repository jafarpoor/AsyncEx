using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginInvoke
{
    public class ClassInvoke
    {
        public delegate int MathOperation(int n1, int n2);

        //public void GetValue()
        //{
        //    MathOperation mathOperation = new MathOperation(Add);
        //    Console.WriteLine("Thread {0}", Thread.CurrentThread.ManagedThreadId);
        //    var Result = mathOperation.BeginInvoke(5, 5, null, null);
        //    while (!Result.IsCompleted)
        //    {
        //        Console.WriteLine("task not completed");
        //        Thread.Sleep(200);
        //    }
        //    Console.WriteLine("Task in Main method.");
        //    var answer = mathOperation.EndInvoke(Result);

        //    Console.WriteLine(answer.ToString());   


        //}

        public async void GetValue()
        {
            MathOperation mathOperation = new MathOperation(Add);
            Console.WriteLine("Thread {0}", Thread.CurrentThread.ManagedThreadId);
            var Result = Task.Run(() => mathOperation.Invoke(5 ,5));
            while (!Result.IsCompleted)
            {
                Console.WriteLine("task not completed");
                Thread.Sleep(200);
            }
            Console.WriteLine("Task in Main method.");

            var final = await Result;
            Console.WriteLine(final.ToString());
        }

        static int Add(int a , int b)
        {
            Console.WriteLine("Thread {0}" , Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(200);
            return a+ b;
        }
             
    }
}
