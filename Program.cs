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


