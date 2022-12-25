// Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше или равна 3

Console.Write("Сколько данных вы введете в массив? ");
int size = int.Parse(Console.ReadLine()!);
string[] array = GetArray(size);
Console.WriteLine($"Получен массив [ {String.Join("; ", array)} ]");
string[] newarray = GetNewArray(size);
Console.WriteLine($"Элементы массива меньше трех символов: [ {String.Join("; ", newarray)} ]");


// --------------Metods------------------

string[] GetArray(int size)
{
    string[] result = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите значение массива ");
        result[i] = Console.ReadLine()!;
    }
    return result;
}

string[] GetNewArray(int size)
{
    string[] result = new string[size];
    int j=0;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length < 3)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}