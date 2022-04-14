//Console.WriteLine(Assignment 1);

//Console.WriteLine("Enter rows and columns : ");
//int rows = int.Parse(Console.ReadLine());
//int cols = int.Parse(Console.ReadLine());

//Console.WriteLine();

//int[,] arr = new int[rows,cols];
//Console.WriteLine("Array chi lengtgh : " +arr.Length);

//Console.WriteLine("\nEnter values to be entered in matrix/array : ");
//for (int i=0;i < arr.GetLength(0);i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        arr[i,j] = int.Parse(Console.ReadLine());
//    }
//}

//Console.WriteLine("\nDisplaying Matrix/array : ");
//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        Console.Write(arr[i, j] + "\t");
//    }
//    Console.WriteLine();
//}


//Console.WriteLine("\nPrinting sum of Matrix/array : ");
//int sum = 0;
//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        sum = sum + arr[i, j];
//    }
//}

//Console.WriteLine(sum);

//Console.WriteLine("============================================================");

//Console.WriteLine(Assignment 2);

//Console.WriteLine("\t\t\tFind greatest number from 2D Array using default Math functions/methods\t\t\t");

//Console.WriteLine("\nEnter two values for rows and columns : ");
//int rows = int.Parse(Console.ReadLine());
//int cols = int.Parse(Console.ReadLine());

//int[,] arr = new int[rows, cols];

//int max = 0;
////int min = 0;

//Console.WriteLine("\nEnter values to be entered in matrix/array : ");
//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        arr[i, j] = int.Parse(Console.ReadLine());
//        max = arr.Cast<int>().Max();
//        //min = arr.Cast<int>().Min();
//    }
//}
//Console.WriteLine("Maximum value in 2D array : " + max);
////Console.Write("Minimum value in 2D array : "+min);

//Console.WriteLine("============================================================");
//Console.WriteLine(Assignment 2);

//Console.WriteLine("\t\t\tFind greatest number from 2D Array by using self logic\t\t\t");

//Console.WriteLine("\nEnter two values for rows and columns : ");
//int rows = int.Parse(Console.ReadLine());
//int cols = int.Parse(Console.ReadLine());

//int[,] arr = new int[rows, cols];

//int max = arr[0, 0];
//int min = arr[0, 0];

//Console.WriteLine("\nEnter values to be entered in matrix/array : ");
//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        arr[i, j] = int.Parse(Console.ReadLine());

//        //Assign current array element to max, if (arr[i,j] > max)
//        if (arr[i, j] > max)
//            max = arr[i, j];

//        //Assign current array element to min if if (arr[i,j] < min)
//        //if (arr[i, j] < min)
//        //    min = arr[i, j];
//    }
//}
//Console.WriteLine("Maximum value in 2D array : " + max);
////Console.Write("Minimum value in 2D array : "+min);
