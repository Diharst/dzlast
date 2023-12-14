// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

int input(string text)
{
    do{
        Console.Write(text);
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 0)
            return index;
        else
             Console.WriteLine("Некорректный ввод. Введите положительное целое число."); 
    } while (true);
}

int[] generate(int size, int rightRange, int leftRange)
{
    Random rand = new Random();
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = rand.Next(rightRange, leftRange-1);
    }
    return newArray;
}

void print(int[] array, int index)
{
    if (index >= 0)
    {
        Console.Write(array[index] + " ");
        print(array, index - 1);
    }
}

int size = input("Введите размер массива: ");
int[] myArray = generate(size, 1, 101);
Console.Write($"[{string.Join(", ", myArray)}] => ");
print(myArray, size - 1);
Console.WriteLine();
