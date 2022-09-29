// Программа из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. 

string[] SelectionElementToNewArray(string[] array, int size)
{
    string[] resultArray = new string[0];

    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= size)
        {
            Array.Resize(ref resultArray, resultArray.Length + 1);
            resultArray[j] = array[i];
            j++;
        }
    }
    return resultArray;
}

string[] sourceArray = { "Hello", "2", "world", ":-)" };
Console.WriteLine(String.Join(", ", SelectionElementToNewArray(sourceArray, 3)));
