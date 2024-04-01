// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

string ArrayToText (char[,] chars)
{
    string result = "";
    for  (int i =0; i<chars.GetLength(0); i++)
    {
        for  (int j =0; j<chars.GetLength(1); j++)
        {
            result = result + chars[i,j];
        }
    }
    return result;
}

char [,] chars = new char [,]
{{'a','b','c','d'},
 {'y','o','u','!'}};

ArrayToText (chars);
System.Console.WriteLine(chars);
