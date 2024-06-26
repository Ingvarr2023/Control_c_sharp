﻿// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, 
// если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом
// (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 
// должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам.

// Даны три варианта массива строк:

string[] strArray = {"1234", "1567", "-2", "computer science"}; 
// string[] strArray = {"Russia", "Denmark", "Kazan"};
// string[] strArray = {"Hello", "2", "world", ":-)"};

string[] GetArray(string[] strArray)
{
    int newSize = 0;
    foreach (string item in strArray)
    {
        if (item.Length <= 3)
        {
            newSize++;
        }
    }

string[] newArray = new string[newSize];
int i = 0;
    foreach (string item in strArray)
    {
        if (item.Length <= 3)
        {
            newArray[i] = item;
            i++;
        }
    }
    Console.WriteLine($"[{string.Join(", ", newArray)}]");
    return newArray;
}
GetArray(strArray);