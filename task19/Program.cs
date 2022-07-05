System.Console.WriteLine("Введите пятизначное число- ");
int Num;
while (!int.TryParse(Console.ReadLine(), out Num))
{
    System.Console.WriteLine("Введен некорректный символ, введите пятизначное ЧИСЛО");
}

System.Console.WriteLine($"Число {Num} удовлетворяет критериям");

while (Num > 99999 | Num < 10000)
{
    System.Console.WriteLine("Введено некорректное число, введите пятизначное");
    int.TryParse(Console.ReadLine(), out Num);
}

int[] array = new int[5];
for (int i = 1; i  <5; i++)
{
    int divNumb = 10000;
    for (; divNumb > 0; divNumb /= 10)
    {
        array[i] = Num / divNumb;
    }

    System.Console.Write($"{array[i]}" + "  ");
}