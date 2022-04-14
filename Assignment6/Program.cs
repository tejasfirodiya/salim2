//    1
//  2 3 2
//3 4 5 4 3
//  2 3 2
//    1

//Console.WriteLine("====================================================================");

// 0 1 2 3 4
//0    *
//1  * * *
//2* * * * *
//3  * * *
//4    *

Console.WriteLine("Enter how many rows and columns : ");
int rows = int.Parse(Console.ReadLine());
int cols = int.Parse(Console.ReadLine());

int[,] arr = new int[rows, cols];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (i==rows/2 || j==cols/2 || i==j || ((i+j)==(rows-1)) && i!=0 && j!=0 && (i+j)!=(rows-1))
            Console.Write("*\t");
        else
            Console.Write("\t");

        //if (i!=0 && j!=0 || i!=rows && j!=rows || i+j==rows-1)
        //{
        //    Console.Write("");
        //}
    }
    Console.WriteLine();




}
