//Without using the hackerrank editor.
Console.WriteLine("Enter array length.");
int arrayLength = int.Parse(Console.ReadLine());
int[] array = new int[arrayLength];

for(int i = 0; i < arrayLength; i++)
{
    Console.WriteLine("Enter the {0}. element of the array", i+1);
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("-------------- Array sort --------------");
Array.Sort(array);
foreach(int i in array)
{
    Console.WriteLine(i);
}
int a = arrayLength - 1;
int candles=0;
Console.WriteLine("Largest element of array "+array[a]);
foreach(int i in array)
{
    if (array[a] == i)
    {
        candles = candles + 1;
    }
}
Console.WriteLine(candles);
