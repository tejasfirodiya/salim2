
Console.WriteLine("\t\t\tFind greatest number & prime number from 2D Array\t\t\t");

Console.WriteLine("\nEnter two values for rows and columns : ");
int rows = int.Parse(Console.ReadLine());
int cols = int.Parse(Console.ReadLine());

int[,] arr = new int[rows, cols];

int max = arr[0, 0];

Console.WriteLine("\nEnter values to be entered in matrix/array : ");
//to check for greater number
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = int.Parse(Console.ReadLine());

        if (arr[i, j] > max)
            max = arr[i, j];

    }
}
Console.WriteLine("Maximum value in 2D array : " + max);

//this is to check for number primeness
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (IsPrime(arr[i, j]))
            Console.WriteLine($"{arr[i, j]} is Prime");
    }
}

bool IsPrime(int Num) //num = 5
{
    for (int i = 2; i < Num; i++)
    {
        if (Num % i == 0) // 5 %2==0
            return false;
    }
    return true;
}