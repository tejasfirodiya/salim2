//*   *
// * *
//  *
// * *
//*   *

Console.WriteLine("\t\t\tPrint Above pattern\t\t\t");

Console.WriteLine("\nEnter two values for rows and columns : ");
int rows = int.Parse(Console.ReadLine());
int cols = int.Parse(Console.ReadLine());

int[,] arr = new int[rows, cols];

for (int i=2;i<=arr.GetLength(0)+1; i++)
{
    for (int j = 2; j <= arr.GetLength(1)+1; j++)
    {
        if (i == j || ((i + j) == (rows+3)))
            Console.Write("*\t");
        else
            Console.Write("\t");
    }
    Console.WriteLine();
}