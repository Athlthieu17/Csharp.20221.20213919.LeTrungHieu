using System;

namespace CS_Lambda
{
    class Program
    {
            /* 
            Lambda - Anonymous function

            1)
            (tham so) => bieu_thuc;

            2)
            (tham so) => {
                cac bieu_thuc;
                return bieu_thuc_tra_ve;
            }


             */
        static void Main(string[] args)
        {
            // Action<string> notify;
            // notify = (string s) => Console.WriteLine(s); // ~delegate void Kieu(string s) = Action<string>

            // notify?.Invoke("Hello");
            // (int a, int b) => 
            // {
            //     int kq = a+b;
            //     return kq;
            // }

            int[] mang = {2,4,64,5,7,8,9,33,35};
            // var kq = mang.Select((int x) => 
            // {
            //     return Math.Sqrt(x);
            // });
            // foreach (var result in kq)
            // {
            //     Console.WriteLine(result);
            // }
            var kq = mang.Where(

                (x) => {
                    return x%4 ==0;
                }
            );

        }
    }
}