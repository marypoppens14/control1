// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам

string[] array = new string[5] {"cat", "palace", "on", "garden", "to"};
string[] new_array = new string[array.Length];
int j = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
        {
        new_array[j] = array[i];
        j++;
        }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(array);
PrintArray(new_array);