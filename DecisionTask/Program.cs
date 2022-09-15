string[] array = {"bird", "cow", "cat", "dog", "fish", "mouse"};

void PrintArray(string[] matrix)
{
    int length = matrix.Length;
    Console.Write("[\t");
    for (int i = 0; i < length; i++)
    {
        Console.Write("'" + matrix[i] + "'" + ",\t");
    }
    Console.WriteLine("]");
}

void SelectionArray(string[] matrix, int countChar)
{
    int length = matrix.Length;
    Console.Write("[\t");
    for (int i = 0; i < length; i++)
    {        
        if (matrix[i].Length <= countChar) 
        {
            Console.Write("'" + matrix[i] + "'" + ",\t");
        }
    }
    Console.WriteLine("]");
}

PrintArray(array);
SelectionArray(array,3);
