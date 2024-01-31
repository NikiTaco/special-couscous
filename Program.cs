/*
//1
void WriteNumbers(int m, int n)
{
if (m > n)
return;
Console.Write(m + " " );
WriteNumbers(m+1,n);
}
Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
WriteNumbers(m,n);

//2
int AkkermansFunction(int n, int m)
{
if (n == 0) return m + 1;
else if (m == 0) return AkkermansFunction(n - 1, 1);
else return AkkermansFunction(n - 1, AkkermansFunction(n, m - 1));
}
Console.Write("Введите значение n: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение m: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(AkkermansFunction(m, n));

//3
void PrintArray(int[] array, int i = 0)
{
    if (i < array.Length)
    {
    PrintArray(array, i + 1);
    Console.Write(array[i] + " ");
    }
}
int[] array = { 4, 5, 6, 7, 8 };
PrintArray(array);
*/
