
/* Задача 64:
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

static void PrintNumbers(int N)
        {
            Console.Write(N + ", ");
            if (N == 1)
                return;
            else
                PrintNumbers(N - 1);
        }


int N = 5;
PrintNumbers(N);
Console.WriteLine();

/* Задача 66
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

static int SumNumbers(int A, int B)
        {
            if (A == B)
                return B;
            else
                return B + SumNumbers(A, B - 1);
        }

int A = 4, B = 8;
Console.WriteLine(SumNumbers(A, B));
Console.WriteLine();

/* Задача 68:
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

static int Ackermann(int c, int d)
        {
            if (c == 0)
                return d + 1;
            else if (d == 0)
                return Ackermann(c - 1, 1);
            else
                return Ackermann(c - 1, Ackermann(c, d - 1));
        }

int c = 3, d = 2;
Console.WriteLine(Ackermann(c, d));