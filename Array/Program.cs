Console.Clear();
Start();
void Start()
{
    string[] array = { "I'm fine", "Ok", "Hellow world", "Common", "Heh", ":|" };
    Console.WriteLine($"[{String.Join(", ", array)}]");
    int num = LengthArray(array);
    string[] SecondArray = NewArray(array, num);
    Console.WriteLine($"[{String.Join(", ", SecondArray)}]");
}
int LengthArray(string[] array)
{
    int num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) num += 1;
    }
    return num;
}
string[] NewArray(string[] array, int num)
{
    string[] SecondArray = new string[num];
    int f = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            SecondArray[f] = array[i];
            f ++;
        }
    }
    return SecondArray;
}