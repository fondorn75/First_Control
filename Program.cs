// New massive

int[] newArray(int count)
{
    int[] array = new int[count];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 9);
    }
    return array;
}

//Print Array

string PrintArray(int[] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i]} ";
    }
    return result;
}

//Create new array

int[] test = newArray(6);

//
int countChetNumbers(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) temp++;
    }
    return temp;
}

Console.WriteLine("[" + PrintArray(test) + "]");
Console.WriteLine(countChetNumbers(test));