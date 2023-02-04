string phrase1 = ReadString("Введите первое слово/символ/выражение: ");
string phrase2 = ReadString("Введите первое слово/символ/выражение: ");
string phrase3 = ReadString("Введите третье слово/символ/выражение: ");
string phrase4 = ReadString("Введите четвертое слово/символ/выражение: ");

string[] Array = {phrase1, phrase2, phrase3, phrase4};
int count = 0;
int j = 0;

for (int i = 0; i < Array.Length; i++)
{
    if(Array[i].Length <= 3) count++;
}

string[] Result = new string[count];

for (int i = 0; i < Array.Length; i++)
{
    if(Array[i].Length <= 3)
    {
        Result[j]=Array[i];
        j++;
    }
}
PrintArray(Array);
Console.WriteLine();
PrintArray(Result);

string ReadString(string message)
{
    Console.WriteLine(message);
    return Convert.ToString(Console.ReadLine());
}

void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
