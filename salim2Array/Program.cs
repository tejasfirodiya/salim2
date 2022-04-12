//Array Syntax : 
//Console.WriteLine("\n\t\t\tArray Syntax\t\t\t");
//int[] cars;

//int[] cars2 = new int[5];

//int[] Cars2 = new int[5];

//int[] cars3 = { 1, 2, 3, 4, 5 };
//Console.WriteLine("====================================================================================");
//Console.WriteLine("\n\t\t\tSingle Dimensional Dynamic Array\t\t\t");
//Console.Write("Enter size of array : ");
//int sizeArray = int.Parse(Console.ReadLine());

//Console.WriteLine();

//int[] cars2 = new int[sizeArray];

//for (int i=0;i<cars2.Length;i++)
//{
//    Console.Write("Enter Value to store in array : ");
//    cars2[i] = int.Parse(Console.ReadLine());
//}

//Console.Write("\nValues in array : \n");
//for (int i = 0; i < cars2.Length; i++)
//{
//    Console.WriteLine(cars2[i]);
//}
//Console.WriteLine("====================================================================================");
//Console.WriteLine("\n\t\t\Multi Dimensional static Array\t\t\t");
Console.Write("Enter size of array as rows & columns : ");
int rows = int.Parse(Console.ReadLine());
int cols = int.Parse(Console.ReadLine());

Console.WriteLine();
int[,] arr = new int[rows,cols];
Console.WriteLine("Enter value : ");
for (int i = 0; i <= 2; i++)
{
    for (int j = 0; j <= 3 ; j++)
    {
        arr[i,j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("\nDisplaying values in matrix : ");
for (int i = 0; i <= 2; i++)
{
    for (int j = 0; j <= 3; j++)
    {
        Console.Write(arr[i, j]+"\t");
    }
    Console.WriteLine();
}
//Console.WriteLine("====================================================================================");
