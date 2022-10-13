

using System;

Console.WriteLine("---1---\n");
Console.WriteLine("Text: ");
char text;
int space = 0;
do
{
    text = Console.ReadKey().KeyChar;
    if (text == ' ')
        space++;
}
while (text != '.');
Console.WriteLine("\nSpaces: " + space);



Console.WriteLine("---2---\n");
Console.Write("Numbers: "); string? numbers = Console.ReadLine();
char[] arr;
int sum1 = 0;
int sum2 = 0;
arr = numbers!.ToCharArray(0, 6);
int[] ticket = new int[arr.Length];
for (int i = 0; i < arr.Length; i++)
    ticket[i] = Convert.ToInt32(arr[i].ToString());
for (int i = 0; i < ticket.Length / 2; i++)
    sum1 += ticket[i];
for (int i = arr.Length / 2; i < ticket.Length; i++)
    sum2 += ticket[i];
for (int i = 0; i < ticket.Length; i++)
    Console.Write(arr[i]);
if (sum1 == sum2)
{
    Console.WriteLine("\nLUCKY!");

}



Console.WriteLine("---3---\n");
int number;
Console.WriteLine("Enter numbers: ");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
for (int i = A; i <= B; i++)
{
    number = i;
    for (int j = 0; j < i; j++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}



Console.WriteLine("---4---\n");
string? numbers4 = Console.ReadLine();
char[] arr4;
arr4 = numbers4!.ToCharArray(0, numbers4.Length);
for (int i = arr4.Length - 1; i >= 0; i--) Console.Write(arr4[i]);



Console.WriteLine("---5---\n");
Console.Write("Starter balance: "); float money = float.Parse(Console.ReadLine());
Console.Write("% "); float interest = float.Parse(Console.ReadLine());
Console.Write("Final balance: "); float final_money = float.Parse(Console.ReadLine());
float month = 0;
float money_profit = money;
while (money_profit <= final_money)
{
    money_profit *= (1 + interest / 100);
    month++;
}
final_money = money_profit;
float profit = final_money - money;
Console.WriteLine($"Starter balance: {money}\n Final balance: {final_money}\n %: {interest}\n Profit: {profit}\n Time spent: {month}");