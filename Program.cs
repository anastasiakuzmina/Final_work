// функция формирует новый массив из элементов исходного где количество символов в элементе меньше 3
string [] GetShortStr (string [] str)
{
    int k = 0;  // - счетчик количества элементов < 3 
    int length = str.Length;
    string[] resultstr = new string[length];  
    for (int i= 0 ; i < length; i++ )
        if (str[i].Length <= 3 ) // проверяем 
        {
            resultstr[k] = str[i];
            k=k+1;
        }
 Array.Resize(ref resultstr, k); // меняем размерность массива на новую 
return resultstr;
}

void Printstr(string[] str)
{
    if (str.Length == 0) // Проверяем пустой ли массив
    {
        Console.WriteLine("Массив пуст");
    }
    else
    {
        Console.Write("[");
        for (int i = 0; i < str.Length - 1; i++)
        {
            Console.Write($"\"{str[i]}\", ");
        }
        Console.Write($"\"{str[str.Length - 1]}\"");
        Console.WriteLine("]");
    }
}

string[] str1 = { "Hello", "2", "world", ":-)" };
string[] str2 = { "1234", "1567", "-2", "computer science" };
string[] str3 = { "Russia", "Denmark", "Kazan" };
Console.WriteLine("Исходный массив:");
Printstr(str1);
Printstr(str2);
Printstr(str3);
string[] restr1 = GetShortStr(str1);
string[] restr2 = GetShortStr(str2);
string[] restr3 = GetShortStr(str3);
Console.WriteLine($"Массив результирующий (строка меньше или равна 3 символам):");
Printstr(restr1 );
Printstr(restr2 );
Printstr(restr3 );

Console.WriteLine();
