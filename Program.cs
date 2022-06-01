using System;

internal class Program
{
    static void Main(string[] args)
    {
        int maxElements = 30;
        int temporaryRow = 1;
        int temporaryNumber = 0;
        int maxRow = 0;
        int number = 0;
        int[] array = new int[30] { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7, 8, 8 };

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        if (array[0] == array[1])
        {
            temporaryRow += 1;
        }

        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                temporaryRow += 1;
                temporaryNumber = array[i];
            }

            else if (temporaryRow > maxRow)
            {
                maxRow = temporaryRow;
                temporaryRow = 1;
                number = temporaryNumber;
            }

            else if (temporaryRow < maxRow)
            {
                temporaryRow = 1;
            }
        }

        if (array[maxElements - 1] == array[maxElements - 2])
        {
            temporaryRow += 1;

            if (temporaryRow > maxRow)
            {
                maxRow = temporaryRow;
                temporaryRow = 1;
                number = temporaryNumber;
            }

            else if (temporaryRow < maxRow)
            {
                temporaryRow = 1;
            }
        }

        Console.WriteLine("\nЦифра " + number + " повторяется больше всего раз");
        Console.Write("Максимальная длина повторений: " + maxRow + "\n");
    }
}