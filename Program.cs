//Задача 64: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
//M = 1; N = 9. -> "3, 6, 9"  M = 13; N = 20. -> "15, 18"
void Zadacha64()
{
    Console.WriteLine("Введите число М");
    int numberM = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N");
    int numberN = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Числа кратные трём в диапазоне от {numberM} до {numberN}");
    SendNumberThree(numberM, numberN);
}

void SendNumberThree(int numberM = 0, int numberN = 0)
{
    if (numberM > numberN) return;
    else if ((numberM % 3) == 0) Console.Write(numberM + "\t");
    numberM++;
    SendNumberThree(numberM, numberN);
}

//Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

void Zadacha66()

{
    Console.WriteLine("Введите число М");
    int numberM = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N");
    int numberN = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Сумма натуральных элементов в диапазоне от {numberM} до {numberN}");
    SumElement(numberM, numberN);
}

void SumElement(int numberM = 0, int numberN = 0, int sum = 0)
{
    if (numberM > numberN)
    {
        Console.WriteLine(sum);
        return;
    }
    sum += numberM;
    numberM++;
    SumElement(numberM, numberN, sum);
}

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

void Zadacha68()
{
    Console.WriteLine("Введите M");
    double numberM = Convert.ToDouble(Console.ReadLine ());
    Console.WriteLine("Введите N");
    double numberN = Convert.ToDouble(Console.ReadLine ());
    Console.WriteLine($"Результат функции Аккермана при значениях A ({numberM},  {numberN}) равна ");
    FuncAkkerman(numberM, numberN);
}

void FuncAkkerman(double M = 0, double N = 0, double result = 1)
{
    if ((M == 0) && (N == 0))
    {
        Console.WriteLine(result);
        return;
    }
    if ((N > 0) && (M == 0))
    {
        result++;
        N--;
        FuncAkkerman(N, M, result);
    }
    else
    if ((M > 0) && (N == 0))
    {
        result = result*2;
        M--;
        FuncAkkerman(N, M, result);
        result -= 3;
      
    }

}


//Zadacha64();
//Zadacha66();
Zadacha68();
