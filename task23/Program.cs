System.Console.WriteLine("введите любое ЧИСЛО");
int Num;
while (!int.TryParse(Console.ReadLine(), out Num))
{
    System.Console.WriteLine("Введен некорректный символ, введите  ЧИСЛО");
}

System.Console.WriteLine($"Число {Num} удовлетворяет критериям");

for (int i = 1; i < Num; i++)

{

    int result = i * i * i;
    System.Console.Write($"{result} ,");

}
System.Console.WriteLine("\b \b");