Console.WriteLine("Введите значения M и N:");
int M = (Console.ReadLine());
int N = (Console.ReadLine());

PrintNaturalNumbers(M, N);

static void PrintNaturalNumbers(int M, int N)
{
    if (M <= N)
    {
        Console.Write($"{M} ");
        PrintNaturalNumbers(M + 1, N);
    }
}
