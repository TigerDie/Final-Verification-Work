string[] CreateUserStringArray(int length)
{
    string[] array = new string[length];
    for(int i = 0; i < length; i++)
    {
        Console.Write("Input a number of array: ");
        string? value = Console.ReadLine();
        while(value == String.Empty)
        {
            Console.WriteLine("String empty is not a element of array: ");
            value = Console.ReadLine();
        }
        if(value != null) array[i] = value;
    }
    return array;
}
string[] CreateStringArray(string[]array)
{
    int lengthNewArray = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i].Length <= 3) lengthNewArray++;

    string[] newArray = new string[lengthNewArray];
    for(int i = 0, j = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}
void PrintStringArray(string[]array)
{
    Console.Write("Creating array: [");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("'" + array[i] + "'");
        if(i < array.Length - 1) Console.Write(",");
    }
    Console.Write("]");
    Console.WriteLine();
}
try
{
    Console.Write("input size of array: ");
    int sizeArray = Convert.ToInt32(Console.ReadLine());
    while(sizeArray < 0)
    {
        Console.WriteLine("size of array - is a positive integer number.");
        Console.Write("Input a new value: ");
        sizeArray = Convert.ToInt32(Console.ReadLine());
    }
    if(sizeArray == 0)
        Console.WriteLine("size of array = 0. Array is empty: []");
    else
    {
        string[] stringArray = CreateUserStringArray(sizeArray);
        PrintStringArray(stringArray);
        string[] newStringArray = CreateStringArray(stringArray);
        PrintStringArray(newStringArray);
    }
}
catch
{
    Console.WriteLine("Uncorrect input. Try again!");
}
Console.ReadLine();