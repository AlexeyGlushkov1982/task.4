int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] proba(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}
int a = ReadInt("ВВедите размер массива - > ");
int b = ReadInt("ВВедите min массива - > ");
int c = ReadInt("ВВедите max массива - > ");
int[] array = proba(a, b, c);
Console.Write($"[{String.Join(",", array)}]");