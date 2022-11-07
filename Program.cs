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
