int[] CreateArray(int count)
{
    return new int[count];
}
void FillArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i]= new Random().Next(0,10000);
    }
}
string PrintArray2(int[] array)
{
    int count = array.Length;
    string res =String.Empty;
    for (int i = 0; i < count; i++)
    {
        res += $"{array[i]} ";
    }
    return res;
}
void Method(int[] array)
{ for (int i = 0; i < array.Length; i++)
{
    if (array[i] %2 == 0) 
    {Console.WriteLine(array[i]);}
}

{
    
}}
int[] arr = CreateArray(8);
FillArray(arr);
Console.WriteLine(PrintArray2(arr));
Console.WriteLine($"->");
Method(arr);
