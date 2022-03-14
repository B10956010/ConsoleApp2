using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("請輸入數字:");
           int x =Convert.ToInt32(Console.ReadLine());
            if (x % 2 != 0)
            { 
                Console.Write("Weird");
            }
            else if (x>=2 && x<=5)
            {
                Console.Write("Not Weird");
            }
            else if (x >= 6 && x <= 20)
            {
                Console.Write("Weird");
            }
            else if (x%2==0 && x>20)
            {
                Console.Write("Not Weird");
            }
            
            int sum=0;
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("第"+i+"次迴圈");
                sum += i;
            }
            Console.WriteLine(sum);

            for(int n = 1; n <= 5; n++)
            {
                for (int m=0;m<n;m++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            int n;
            Console.WriteLine("請輸入N：");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 3; i++)
            {
                Console.WriteLine(n + "*" + i + "="+n*i);
            }

            for(int i = 2; i <= 9; i++)
            {
                for(int j = 1; j <= 9; j++)
                {
                    Console.Write(i + "*" + j + "=" + i * j+" ");
                }
                Console.WriteLine();
            }*/

            int[] studentNo = { 1, 2, 3, 4, 5 };
            string[] studentName = { "Jack", "Mary", "Tom", "Grace", "Alice" };
            int[] computerScore = { 80, 65, 100, 98, 83 };
            int[] progarmScore = { 75, 67, 93, 25, 82 };
            int[] animationScore = { 60, 62, 91, 50, 87 };
            while (true)
            {
                Console.WriteLine("輸入座號：");
                var input = Console.ReadLine();
                int inputstudentNo = int.Parse(input);
                int arrayIndex = Array.IndexOf(studentNo,inputstudentNo);
                if (arrayIndex > -1)
                {
                    Console.WriteLine("姓名" + studentName[arrayIndex]);
                    Console.WriteLine("電腦概論" + computerScore[arrayIndex]);
                    Console.WriteLine("程式設計" + progarmScore[arrayIndex]);
                    Console.WriteLine("動畫設計" + animationScore[arrayIndex]);
                }
                else
                {
                    Console.WriteLine("沒有這個座號");
                }
            }
        }
          
    }
}
