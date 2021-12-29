// Метод для создания массива с заданным числом элементов

int[] newArray(int count, int on, int off)
{
    int[] array = new int[count];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(on, off);
    }
    return array;
}

//Метод печати массива

string PrintArray(int[] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i]} ";
    }
    return result;
}

//Создаем новый массив 

int[] firstArray = newArray(6, 1, 9);

//Считаем число четных элементов массива

int countChetNumbers(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) temp++;
    }
    return temp;
}

//Присваеваем переменной число четных элементов для создания нового массива
int count = countChetNumbers(firstArray);

//Заполняем второй массив четными элементами первого
int[] SecondArray(int[] array)
{
    int j = 0;
    int[] second = new int[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            second[j] = array[i];
            j++;
        }
    }
    return second;
}

//Печатаем первый массив
Console.WriteLine("[" + PrintArray(firstArray) + "]");

//Печатаем число четных лементов в массиве
Console.WriteLine("Число четных элементов в массиве - " + count);

//Печатаем новый массив
Console.WriteLine("[" + PrintArray(SecondArray(firstArray)) + "]");