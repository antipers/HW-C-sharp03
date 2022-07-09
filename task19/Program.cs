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
int[] array = new int[5];
for (int i = 0; i < array.Length; i++)

{
    int div =10000;
    array[i] = Num /div;
    Num= Num-array[i]*div;
    div /=10;
    System.Console.Write($"{array[i]} , ");
}
 */


Console.WriteLine("Введите пятизначное число:");
string number = Console.ReadLine();

if (number[0] == number[4] && number[1] == number[3])
{ System.Console.WriteLine($"Число {number} является палиндромом, используйте его с умом"); }
else
{ System.Console.WriteLine($"К сожалению или к счастью число {number} не является палиндромом"); }