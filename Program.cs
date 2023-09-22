// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array1 = new string[4] {"aaa"; "sddda"; "asd"; "q"};
string[] arrayNew = new string[array1.Length];

void NewArray(string[] array1, string[] arrayNew) 
{
    int count = 0;
    for (int i=0; i<array1.Length; i++)
    {
        if (array1[i]<=3)
        {
            arrayNew[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i=0; i < array.Length; i++)
    {
        System.Console.WriteLine($"{array[i]} ");
    }
    System.Console.WriteLine();
}

NewArray(array1, arrayNew);
