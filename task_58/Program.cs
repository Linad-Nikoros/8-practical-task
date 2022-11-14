// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] array1 = new int[5, 5];
int[,] array2 = new int[5, 5];

fill_array(array1);
fill_array(array2);
print_array(array1);
Console.WriteLine("_____________________");
print_array(array2);
Console.WriteLine("_____________________");
Multiply();
print_array(array1);

void fill_array(int[,] array002)
{
    for (int i = 0; i < array002.GetLength(0); i++)
    {
        for (int j = 0; j < array002.GetLength(1); j++)
        {
            array002[i, j] = new Random().Next(-100, 100);
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

void Multiply()
{
    int multiply_string;
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            multiply_string = array1[i, j] * array2[i, j];
            array1[i, j] = multiply_string;
        }
    }
}