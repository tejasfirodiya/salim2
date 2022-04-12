//Console.Write("Enter size of array as rows & columns : ");
//int rows = int.Parse(Console.ReadLine());
//int cols = int.Parse(Console.ReadLine());

//Console.WriteLine();
//int[,] arr = new int[rows, cols];
//Console.WriteLine("Enter Values to be printed in matrix : ");
//for(int i = 0;i<=arr.length;i++)
//{
//    for (int j = 0; j <= arr.length; j++)
//    {
//        arr[i,j] = int.Parse(Console.ReadLine());   
//    }
//}

//Console.WriteLine("\nDisplaying values in matrix : ");
//for (int i = 0; i <= 2; i++)
//{
//    for (int j = 0; j <= 3; j++)
//    {
//        if(arr[i,j]%5==0)
//            Console.Write("*\t");
//        else
//            Console.Write(arr[i, j] + "\t");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine("====================================================================================");

//int[,] arr = new int[2, 3];
//Console.WriteLine(arr.Length);
//var row = arr.GetLength(0); // syntax to get the length of row
//var col = arr.GetLength(1); // syntax to get the length of cols
//Console.WriteLine(row);
//Console.WriteLine(col);
//Console.WriteLine("====================================================================================");

//for (int i = 0; i <=3; i++)
//{
//    for(int j = 0; j<=3; j++)
//    {
//        if (j<i)
//            Console.Write("\t");
//        else
//            Console.Write("*\t");

//    }
//    Console.WriteLine();
//}
//Console.WriteLine("====================================================================================");

//1 1 1 1 1
//1       1
//1       1
//1 1 1 1 1

//Console.Write("Enter size of matrix as rows & columns : ");
//int total = int.Parse(Console.ReadLine());

//for (int i = 0; i < total; i++)
//{
//    for (int j = 0; j < total; j++)
//    {
//        if (i == 0 || i == total-1 || j == 0 || j == total - 1)
//            Console.Write("*\t");
//        else
//            Console.Write("\t");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("====================================================================================");
//1     1
//  1 1 
//   1
//  1  1 
//1     1
//Console.WriteLine("====================================================================================");
//*
//*
//*
//* * * *
//Console.WriteLine("\t\t\tStatic\t\t\t");
//for (int i = 0; i<=3; i++)
//{
//    for (int j = 0; j <= 3; j++)
//    {
//        if(i == 3 || j == 0)
//        {
//            Console.Write("*\t");
//        }
//        else
//            Console.Write("\t");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine("\t\t\tDynamic\t\t\t");



//Console.WriteLine("====================================================================================");

//* * * *
//      *
//      *
//      *


//Console.WriteLine("\t\t\tStatic\t\t\t");
//for (int i = 0; i <= 3; i++)
//{
//    for (int j = 0; j <= 3; j++)
//    {
//        if (i == 0 || j == 3)
//        {
//            Console.Write("*\t");
//        }
//        else
//            Console.Write("\t");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine("\t\t\tDynamic\t\t\t");


//Console.WriteLine("====================================================================================");
//Console.WriteLine("\t\t\tDynamic\t\t\t");
//* * * *
//*     *
//* * * *
//*
//*
//*


Console.Write("Enter size of matrix as rows & columns : ");
int rows = int.Parse(Console.ReadLine());
int cols = int.Parse(Console.ReadLine());

int res = rows/2;
for (int i = 0; i <= rows; i++)
{
    for (int j = 0; j <= cols; j++)
    {
        if (i == 0 || i==res || j == 0 || (j==cols && i<res))
            Console.Write("*\t");
        else
            Console.Write("\t");

        //if(i==1 && j==cols-1 || i == 2 && j == cols - 1)
        //    Console.Write("*\t");

        //while(j==res)
        //{
        //    Console.Write("*\t");
        //    break;
        //}


    }
    Console.WriteLine();
}

//Console.WriteLine("====================================================================================");
