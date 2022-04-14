
//Console.WriteLine("====================================================================================");

//Assignments Day02

//note :- all multi dimensional array.

//1. Define array with dynamic value & print sum of the array.

//2. Define array with dynamic value & find greatest of the array & also print prime numbers.

//Console.WriteLine("====================================================================================");



Console.WriteLine("Enter two values for rows and columns : ");
int rows = int.Parse(Console.ReadLine());
int cols = int.Parse(Console.ReadLine());

int sum = 0;

int[,] arr = new int[rows, cols];

Console.WriteLine("\nEnter values to be entered in matrix/array : ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = int.Parse(Console.ReadLine());
        sum = sum + arr[i, j];
    }
}
Console.WriteLine($"\nPrinting sum of Matrix/array : {sum}");
