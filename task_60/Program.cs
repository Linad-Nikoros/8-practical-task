//  Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] array1 = new int[3, 3, 3];
int[] array2 = new int[100];

FillArray(array1,array2);
PrintArray(array1);



void FillArray (int[,,] array10,int[] array20)
{
int count = 0;
for (int i = 0; i < array20.Length; i++)
{
    array20[i] = count;
    count++;
}

for (int i = array20.Length - 1; i >= 1; i--)
{
    int j = new Random().Next(i);
    int temp;
    temp = array20[j];
    array20[j] = array20[i];
    array20[i] = temp;
}


int count2 = 0;
for (int i = 0; i < array10.GetLength(0); i++)
{
    
    for (int j = 0; j < array10.GetLength(1); j++)
    {
        for (int k = 0; k < array10.GetLength(2); k++)
        {
            array10[i, j, k] = array20[count2];
            count2++;
        }
    }
}
}


void PrintArray(int[, ,] array10)
{
for (int i = 0; i < array10.GetLength(0); i++)
{
    Console.WriteLine( $"{i+1} страница");
    for (int j = 0; j < array10.GetLength(1); j++)
    {
        for (int k = 0; k < array10.GetLength(2); k++)
        {
            Console.Write($"{array10[i, j, k]}({i};{j};{k}) ");
        }
    }
    Console.WriteLine();
}
}



