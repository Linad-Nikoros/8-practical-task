// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Console.WriteLine("Введите количкство строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
int[,] array1 = new int[4, 4];

fill_array(array1);
print_array(array1);
Console.WriteLine("___________");
sorting(array1);
print_array(array1);


void fill_array(int[,] array002)
{
    for (int i = 0; i < array002.GetLength(0); i++)
    {
        for (int k = 0; k < array002.GetLength(1); k++)
        {
            array002[i, k] = new Random().Next(0, 100);
        }
    }
}

void print_array(int[,] array001)
{
    for (int i = 0; i < array001.GetLength(0); i++)
    {
        for (int k = 0; k < array001.GetLength(1); k++)
        {
            Console.Write(array001[i, k] + " ");
        }
        Console.WriteLine();
    }
}

void sorting(int[,] array001)

{
    int index;
    int current_number;

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            
            for(int k =0;k<array1.GetLength(1);k++)
            {
            index = k;
            current_number = array1[i, k];
            while (index > 0 && current_number > array1[i, k - 1])
            
            {
                array1[i, index] = array1[i, index - 1];
                array1[i, index-1] = current_number;
                index = index - 1;
            }
            }

        }

    }

}

