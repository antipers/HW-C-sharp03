//попытка через вывод в массив неудачно
/* System.Console.WriteLine("Введите пятизначное число- ");
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
int[] array = new int[4];
for (int i = 4; i > 0; i--)
{
    array[i] = number % 10;
    number /= 10;
    System.Console.WriteLine(array[i]);
}
 */


Console.WriteLine("Введите пятизначное число:");
string number = Console.ReadLine();

if (number[0] == number[4] && number[1] == number[3])
{ System.Console.WriteLine($"Число {number} является палиндромом, используйте его с умом"); }
else
{ System.Console.WriteLine($"К сожалению или к счастью число {number} не является палиндромом"); }