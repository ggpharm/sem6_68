// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



int inpuNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int AkkNum(int m, int n)
{   
    if (m == 0) return n + 1;
    if (n == 0) return AkkNum(m - 1, 1);
    else
    return AkkNum(m-1, AkkNum(m, n - 1));
}

int numM = inpuNum("Введите M: ");
int numN = inpuNum("Введите N: ");
int result = AkkNum(numM, numN);

Console.WriteLine("");
Console.WriteLine("Вычисление по Аккерману =  " + result);