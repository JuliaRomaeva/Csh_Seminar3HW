// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число : ");
string s = Console.ReadLine();
Int32 l = s.Length;
if (l == 5) 
{
 if(s[0] == s[4] && s[1] == s[3])
    Console.Write($" {s} -> да ");
else{
    Console.Write($" {s} -> нет ");
    }
}
else{
    Console.Write(" введено неверное число ");
}


// Второй способ
// Console.Clear();
// Console.Write("Введите пятизначное число : ");
// int num = int.Parse(Console.ReadLine());
// if(num < 10000 || num > 99999){
//  Console.WriteLine("Введено неправильное число");
//  return;
// }
// else{
//     if( num / 10000 == num % 10 && (num / 1000) % 10 == (num - (num/100 * 100))/10) {
//         Console.WriteLine($"{num} -> да ");
//     }
//     else{
//         Console.WriteLine($"{num} -> нет ");
//     }
// }

// третий метод
// Console.Clear();
// Console.Write("Введите число : ");
// int num = int.Parse(Console.ReadLine());int Revers(int num){
// int revers = 0;// 54321
// while (num > 0)
// { // num = 0 > 0 54320
// revers = revers * 10 + num % 10; // revers = 5432 * 10 + num%10(1%10 = 1) = 54321
// num /= 10; // num / 10(1/10)
// }// 12345 == 54321
// return revers;
// }
// if (num == Revers(num))
// {
// Console.Write("Да");
// }
// else
// {
// Console.Write("Нет");
// }