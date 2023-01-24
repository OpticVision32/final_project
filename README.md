# Принимаем данные массива строк
    string[] strArray = { "hello", "2", "world", ":-)" };
# Задаём необходимые переменные
    int count = 0;
    int index = 0;
    string temporary = string.Empty;
    int i;
# С помощью цикла _**for**_ вычисляем длину нового массива и заодно сдвигаем все нужные элементы влево
    for</for> (i = 0; i < strArray.Length; i++)
    {
        if (strArray[i].Length <= 3)
        {
            temporary = strArray[index];
            strArray[index] = strArray[i];
            strArray[i] = temporary;
            count++;
            index++;
        }
    }
# Инициализируем новый массив строк
    string[] newStrArray = new string[count];
# С помощью цикла _**for**_ заполняем новый массив нужными нам данными
    for (i = 0; i < newStrArray.Length; i++)
    {
        newStrArray[i] = strArray[i];
    }
# А затем выводим полученный массив в консоль
    for (i = 0; i < newStrArray.Length; i++)
    {
        Console.Write(newStrArray[i] + " ");
    }