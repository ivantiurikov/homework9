//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

// void ShowNumbers(int n)
// {
//     if(n>=1)
//     {
//         Console.Write(n+" ");
//         ShowNumbers(n-1);
//     }
// }

// Console.WriteLine("Input the number:");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("The result is:");
// ShowNumbers(N);


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int FindSum (int m, int n)
// {
//     if(n>=m)
//     {
//         return FindSum(m, n-1) + n;
//     }
//     else
//     return 0;
// }

// Console.WriteLine("Input the number M (M<N):");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input the number N (M<N):");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("The sum is:");
// Console.WriteLine(FindSum(M, N));



//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// int Ack(int m, int n)
// {
//     if(m==0) return n+1;
//     else if(n==0) return Ack(m-1, 1);
//     else return Ack(m-1, Ack(m, n-1));
// }

// Console.WriteLine("Input the number m:");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input the number n:");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("The result is:");
// Console.WriteLine(Ack(M, N));