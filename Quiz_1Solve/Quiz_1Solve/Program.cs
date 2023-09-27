namespace Quiz_1Solve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] myAcc = new int[3][];
            myAcc[0] = new int[] { 200, 450, 600, 300 };
            myAcc[1] = new int[] { 800, 350, 170 };
            myAcc[2] = new int[] { 480, 860, 350, 900 };

            callFun1(myAcc);

            for (int i = 0; i < myAcc.Length; i++)
                for (int j = 0; j < myAcc[i].Length; j++)
                {
                    if (i == 2)
                        Console.Write(myAcc[i][j] + " ");
                }
            void callFun1(int[][] arr)
            {
                int a = 0;
                for(int i = 0; i<arr.Length; i++)
                {
                    for(int j= 0; j < arr[i].Length; j++)
                    {
                        a +=arr[i][j];
                    }
                    arr[2][i] = a;
                    Console.WriteLine("{0}:{1}", i + 1, a);
                    a = 0;
                }
                Console.Write(arr.Length);
                Console.WriteLine(arr.Rank);
            }
        }
    }
}