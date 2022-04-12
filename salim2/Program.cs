//Console.WriteLine("\t\t\tWhile Loop - find even & odd \t\t\t");
//int a = 1;
//while(a<=20)
//{
//    string result = a % 2 == 0 ? $"{a} is even" : $"{a} is odd";
//    Console.WriteLine(result);

//    a++;
//}
//Console.WriteLine("====================================================================================");
//Console.WriteLine("\t\t\tWhile Loop - divide by 5 & 2 ass\t\t\t");
//
//int a = 0;
//while(a<=100)
//{
//    //if (a % 5 == 0 && a % 2 == 0)
//    //    Console.WriteLine(a);

//    string result = (a % 5 == 0 && a % 2 == 0) ? $"{a} Divide by 5 & 2" : "none";
//    Console.WriteLine(result);

//    a+=10;
//}
//Console.WriteLine("====================================================================================");
//Console.WriteLine("\t\t\tWhile Loop - Prime number\t\t\t");
//Console.WriteLine("Enter a number to check its primeness : ");
//int num = int.Parse(Console.ReadLine());
//int i = 2;
//bool flag = true;
//while (i<num )
//{
//    if ((num % i) == 0)
//    {
//        flag = false;
//        break;    
//    }
//    i++;
//}

//if(flag)
//    Console.WriteLine("Prime");
//else
//     Console.WriteLine("not prime");
//Console.WriteLine("====================================================================================");
//Console.WriteLine("\t\t\For Loop - eg\t\t\t");
//for(int i = 0;i<10;i++)
//{
//    Console.WriteLine("Hello");
//}

//Console.WriteLine("\t\t\tFor Loop - Odd Number\t\t\t");
//for (int i = 1;i<=100;i++)
//{
//    if(i%2!=0)
//        Console.WriteLine(i);
//}

//Console.WriteLine("\t\t\tFor Loop - find number divide by 5 & 2\t\t\t");
//for (int i = 0;i<=100;i+=10)
//{
//    string result = (i % 5 == 0 && i % 2 == 0) ? $"{i} Divide by 5 & 2" : "none";
//    Console.WriteLine(result);

//}
//Console.WriteLine("====================================================================================");
    //Console.WriteLine("\n\t\t\tFor Loop - 3(ROWS) by 4(COLUMNS) matrix 0 printing\t\t\t");
//0 0 0 0
//0 0 0 0
//0 0 0 0

//for (int i = 1; i <= 3 ; i++)   //this FOR is for ROWS in matrix
//{
//    for(int j = 1;j<=4;j++)    //this FOR is for COLUMNS in matrix
//    {
//        Console.Write("0\t");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("====================================================================================");

//Console.WriteLine("\n\t\t\tFor Loop - 6(ROWS) by 6(COLUMNS) matrix 1 printing\t\t\t");
//1 1 1 1 1 1
//1 1 1 1 1 1
//1 1 1 1 1 1
//1 1 1 1 1 1
//1 1 1 1 1 1
//1 1 1 1 1 1

//for (int i = 1; i <= 6; i++)   //this FOR is for ROWS in matrix
//{
//    for (int j = 1; j <= 6; j++)    //this FOR is for COLUMNS in matrix
//    {
//        Console.Write("1\t");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("====================================================================================");
//Console.WriteLine("\n\t\t\tFor Loop - 3 by 3 matrix number printing\t\t\t");
//1
//1 2
//1 2 3
Console.WriteLine("1. Your this is remaining.. Plese do it bro!!!!");

//for (int i = 1; i <=3; i++)
//{
//    for(int j=1;j<=3;j++)
//    {
//        Console.Write(j+"\t");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("====================================================================================");
//Console.WriteLine("\n\t\t\tFor Loop - 3 by 3 matrix number printing\t\t\t");
//0 0 0 0
//2 2 2 2
//0 0 0 0
//for (int i = 1;i<=3;i++)
//{
//    for (int j=1;j<=4;j++)
//    {
//        if(i==2)
//        Console.Write("2\t");
//        else
//            Console.Write("0\t");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("====================================================================================");
//Console.WriteLine("\n\t\t\tFor Loop - diagonally 1 print others 0\t\t\t");
//for (int i = 1;i<=3;i++)
//{
//    for(int j=1;j<=3;j++)
//    {
//        if(i==2 && j==2)
//        Console.Write("1\t");
//        else
//        Console.Write("0\t");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("====================================================================================");
//Console.WriteLine("\n\t\t\tFor Loop - dynamically diagonally 1 print others 0\t\t\t");
//Console.WriteLine("Enter number of rows : ");
//int rows = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter number of columns : ");
//int cols = int.Parse(Console.ReadLine());

//for (int i = 1; i <= rows; i++)
//{
//    for (int j = 1; j <= cols; j++)
//    {
//        if (i == j)
//            Console.Write("1\t");
//        else
//            Console.Write("0\t");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("====================================================================================");

//Console.WriteLine("\n\t\t\tFor Loop - dynamically both side diagonally 1 print others 0\t\t\t");
//1 0 0 1
//0 1 1 0
//0 1 1 0
//1 0 0 1
Console.WriteLine("2. Your this is remaining.. Plese do it bro!!!!");

//Console.WriteLine("Enter number of rows : ");
//int rows = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter number of columns : ");
//int cols = int.Parse(Console.ReadLine());

//for (int i = 1; i <= rows; i++)
//{
//    for (int j = 1; j <= cols; j++)
//    {
//        if (i)
//            Console.Write("1\t");
//        else
//            Console.Write("0\t");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("====================================================================================");

//1
//2 3
//4 5 6
Console.WriteLine("Enter number of rows : ");
int rows = int.Parse(Console.ReadLine());

int a = 1;
for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j<=rows; j++)
    {
        if (j <= i)
        {
            Console.Write(a + "\t");
            a++;
        }
        else
            Console.Write("0\t");
    }
    Console.WriteLine();
}
//Console.WriteLine("====================================================================================");
