/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
*/

string[] InitialArray = {"Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan", "1", "11","111","1111"};


int p = 0;
for (int i = 0; i < InitialArray.Length; i++)
{
    Console.Write(InitialArray[i] + "  ");
    if (InitialArray[i].Length <= 3)       
        p++;
}


string[] ResultingArray = new string[p];
Console.WriteLine();

p = 0;

for (int i = 0; i < InitialArray.Length; i++)
{
    if (InitialArray[i].Length <= 3)
    {
        ResultingArray[p] = InitialArray[i];
        Console.Write(ResultingArray[p] + "  ");
        p++; 
    }
}
