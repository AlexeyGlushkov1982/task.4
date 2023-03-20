// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow, не будут считаться правильными, так как задача стоит в том, чтобы написать цикл)

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// ------------------------------------1 вариант---------------------------------- 

// int ReadInt(string text)
// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }
// void proiz(int coords1, int coords2)
// {
//     int result = 1;
//     for (int i = 0; i < coords2; i++)
//     {
        
//         result = result * coords1;
//     }
//     Console.Write($"результат - > {result}");
// }
// int[] massiv = new int[2];
// massiv[0] = ReadInt("введите первое число - > ");
// massiv[1] = ReadInt("введите второе число - > ");
// proiz(massiv[0], massiv[1]);

// ------------------------------------2 вариант----------------------------------

// int ReadInt(string text)
// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int a = ReadInt("первое число - ");
// int b = ReadInt("второе число - ");
// int proiz = 1;
//     for (int i = 0; i < b; i++)
// {
//     proiz = proiz * a;
// }
// Console.WriteLine($"answer - > {proiz}");