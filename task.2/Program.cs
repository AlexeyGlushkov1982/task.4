// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// int ReadInt(string text)
// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int count = ReadInt("Введите число - > ");
// int i = 0;
// while (count > 0)
// {
//     i = i + count % 10;
//     count = count / 10;
// }
// Console.WriteLine(i);


// int ReadInt(string text)
// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }
// void result(int y)
// {
//     int i = 0;
//     while (y > 0)
//     {
//         i = i + y % 10;
//         y = y / 10;
//     }
//     Console.Write($"результат - {i}");
// }
// int count = ReadInt("Введите число - > ");
// result(count);