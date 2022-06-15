using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncPro
{
    public  class Delegates
    {
        public delegate void StartJobDelegate();

        //public void GetJob()
        //{
        //    StartJobDelegate jobDelegate = new StartJobDelegate(StartJob);
        //    jobDelegate.Invoke();
        //}

        //void StartJob()
        //{
        //    for (int i = 0; i < 10000; i++)
        //    {
        //        Console.WriteLine("Number is {0} :", i +Environment.NewLine);

        //    }
        //}


        public void GetJob()
        {
            var Result = new Func<int, int, int>(Sum);
            var callBack = new AsyncCallback(p =>
            {
                var finalResult = Result.EndInvoke(p);
                Console.WriteLine("FinalResult {0}", finalResult);
            });

            var sumnumber = Result.BeginInvoke(9, 20, callBack, null);
        }
        int Sum(int num1 , int num2)
        {
            return num1 + num2;
        }
    }
}
