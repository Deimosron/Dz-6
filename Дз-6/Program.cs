///---Дз 6---\\\

class Program
{
    static void Main()
    {
        int[] number = { 10, 20, 30, 40, 50 };
        Console.Write("Начальный массив: ");
        for (int i = 0; i < number.Length; i++)
        {
            Console.Write(number[i] + " ");
        }
        Console.WriteLine();
        int[] new_number = new int[number.Length];
        for (int i = 0; i < number.Length; i++)
        {
            new_number[i] = number[number.Length - 1 - i];
        }
        Console.Write("Перевернутый массив: ");
        for (int i = 0; i < new_number.Length; i++)
        {
            Console.Write(new_number[i] + " ");
        }
        Console.WriteLine();

        Console.ReadLine();
    }
}