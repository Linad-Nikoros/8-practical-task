// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int[rows, columns];

fill_array(array1);
print_array(array1);
void fill_array(int[,] array002)
{
    for (int i = 0; i < array002.GetLength(0); i++)
    {
        for (int j = 0; j < array002.GetLength(1); j++)
        {
            array002[i, j] = new Random().Next(0, 10);
        }
    }
}

void print_array(int[,] array001)
{
    for (int i = 0; i < array001.GetLength(0); i++)
    {
        for (int j = 0; j < array001.GetLength(1); j++)
        {
            Console.Write(array001[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int line_number = 0;
int sum_of_lines = 0;
int min_sum_rows = 0;
for (int i = 0; i < array1.GetLength(0); i++)
{
    sum_of_lines = 0;
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        sum_of_lines = sum_of_lines + array1[i, j];
    }
    if (i == 0)
    {
        min_sum_rows = sum_of_lines;
    }
    if (sum_of_lines < min_sum_rows)
    {
        min_sum_rows = sum_of_lines;
        line_number = i + 1;
    }
}
Console.WriteLine($"Строка с минимальной суммой находиться под номером: {line_number} ");
Console.WriteLine($"Минимальная сумма строки = {min_sum_rows}");
