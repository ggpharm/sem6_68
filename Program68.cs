// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



int inpuNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int AkkNum(int n, int m)
{   
    if (n == 0) return m + 1;
    if (m == 0) return AkkNum(n - 1, 1);
    else
    return AkkNum(n-1, AkkNum(n, m - 1));
}

int numM = inpuNum("Введите M: ");
int numN = inpuNum("Введите N: ");
int result = AkkNum(numM, numN);

Console.WriteLine("");
Console.WriteLine("Вычисление по Аккерману =  " + result);