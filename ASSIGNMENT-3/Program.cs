namespace ASSIGNMENT_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // answer 1 
            //#region array 1d
            ////   double[] prices =new double[] { 22.5, 40.32, 33, 75 };  ممكن تتكتب كدا بس مش محببه 
            //double[] prices = { 22.5, 40.32, 33, 75 };
            //Console.WriteLine(prices[1]);
            ////  الكود دا حبيت ان المستخدم هو الي يدخل الارقام و يعمل الloop  المناسب للطباعه 
            //double[] prices2 = new double[3];
            //for(int i = 0; i < prices2.Length; i++)
            //{
            //    Console.Write("enter number of array :");
            //    prices2[i] = double.Parse(Console.ReadLine());



            //}
            //Console.WriteLine(prices2[1]);
            //#endregion

            //answer2
            #region Array 2D
            int[,] shelfCopies =
            {
                {3,5},
                {1,4}
            };

            Console.WriteLine(shelfCopies[1, 0]);
            #endregion






        }
    }
}
