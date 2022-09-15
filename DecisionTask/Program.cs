string[] array = { "bird", "cow", "cat", "dog", "fish", "mouse" };

string[] newArray = {"", "", "", "", "", ""};

void PrintArray(string[] matrix)
{
    int length = matrix.Length;
    Console.Write("[\t");
    for (int i = 0; i < length; i++)
    {
        if (matrix[i] != string.Empty)
        Console.Write("'" + matrix[i] + "'" + ",\t");
    }
    Console.WriteLine("]");
}

void SelectionArray(string[] matrix, string[] newMatrix, int countChar)
{
    int j = 0;      
    int length = matrix.Length;
    for (int i = 0; i < length; i++)
    {
        if (matrix[i].Length <= countChar)
        {
            newMatrix[j] = matrix[i];
            j++;            
        }
    }
}


PrintArray(array);
SelectionArray(array,newArray, 3);
PrintArray(newArray);

