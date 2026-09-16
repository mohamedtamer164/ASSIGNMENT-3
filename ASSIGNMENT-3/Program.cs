namespace ASSIGNMENT_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////  answer 1
            //  #region array 1d
            //  //   double[] prices =new double[] { 22.5, 40.32, 33, 75 };  ممكن تتكتب كدا بس مش محببه 
            //  double[] prices = { 22.5, 40.32, 33, 75 };
            //  Console.WriteLine(prices[1]);
            //  //  الكود دا حبيت ان المستخدم هو الي يدخل الارقام و يعمل الloop  المناسب للطباعه 
            //  double[] prices2 = new double[3];
            //  for (int i = 0; i < prices2.Length; i++)
            //  {
            //      Console.Write("enter number of array :");
            //      prices2[i] = double.Parse(Console.ReadLine());



            //  }
            //  Console.WriteLine(prices2[1]);
            //  #endregion

            //// answer2
            // #region Array 2D
            // int[,] shelfCopies =
            // {
            //     {3,5},
            //     {1,4}
            // };

            // Console.WriteLine(shelfCopies[1, 0]);
            // #endregion


            //#region mehtods
            //static void PrintWelcomeMessage()
            //{
            //    Console.WriteLine("Welcome to the Library!");

            //}

            //PrintWelcomeMessage();
            //#endregion

            //// answer 4
            //static void PrintBookTitle(string title)
            //{
            //    Console.WriteLine("Book title: " + title);
            //}



            //    PrintBookTitle("Clean Code");

            //// ANSWER 5 
            //#region passing by value
            //int pages = 400;//  هنا انت هتخزن عادي ف الداله ال جوا ان ال  pages ب 400 
            //helper.AddBonusPages(pages); //  و هنا انت برضو خزنت هناك و استخدمت الداله و المفروض ب 450 
            //Console.WriteLine(pages);  // 400?? ليه بقا عشان انت خزنت كل واحد ف مكان معين ف ال stack  كل واحد شغال مع نفسه بس مش ليهم ref 
            //// حلها اني اديله ref
            //#endregion


            // answer 6
            //#region passing by refrance

            //double[] prices = { 25.5, 40.0 }; // هنا خزنت ف الداله  و ف ال  stack  مكان  ليها و لهذا الجزء لوحدوا 

            //helper.ApplyDiscount(prices);//  الي انت عاوزه تنها تطبع اول عنصر و تطرح منه 5 و هنا انت هتستخدم الداله برضو بس ف مكانها لكن مش هتعرض

            //Console.WriteLine(prices[0]); // اول عنصر هيكون زي م هو 
            //// 2.5  عشانت برضو انت م ظبطش الكود و اديته قثب انه يشاور عليه
            //#endregion


            //// answer 7 
            //#region ref

            //int pages = 400;

            //helper.  AddBonusPages(ref pages);

            //Console.WriteLine(pages);
            //// هنا اتغيرت اهي 
            //#endregion

            //// answer 8 
            //#region ref refrances type 

            //double[] prices = { 25.5, 40.0 }; // هنا كان بياشور علي ل  array دي

            //helper. ReplaceArray(ref prices); // هنا هيلغي انه يشاور عليها لكن هتفضل متخزنه جوا ال  heap بس مش هقدر اوصلها

            //Console.WriteLine(prices.Length);
            //// هنا استخدمنا ال ref  عشان يعدل ال array  كلها   هو كان 
            //#endregion

            ////answer 9

            //if (helper.TryGetPrice("Clean Code", out double price))
            //{
            //    Console.WriteLine(price);
            //}


            // answer 10 
            #region answer 10

             helper.PrintBookInfo("Clean Code");

             helper.PrintBookInfo("C# Basics", 400);
            #endregion
        }

    }
}
