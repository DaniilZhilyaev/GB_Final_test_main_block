/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

// Метод отделения элементов с длинной символов меньше 3х в отдельный массив
string[] SelectArray(string[] arr)
{
    string elements = "";
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            if (elements == "") elements = arr[i];
            else elements = elements + " " + arr[i];
        }
    }
    string[] res = elements.Split(new char[] { ' ' });
    return res;
}

// Метод создания массива со строками
string[] GetArray(int n)
{
    string[] res = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Введите элемент массива: ");
        res[i] = Console.ReadLine()!;
    }
    return res;
}
