Console.WriteLine("Enter array length");
int arrayLength = int.Parse(Console.ReadLine());
int[] array = new int[arrayLength];
for (int i = 0; i < arrayLength; i++)
{
    Console.WriteLine("Enter {0}. number", i + 1);
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int eksikNum = 0;
for (int i = 0; i < arrayLength - 1; i++)
{
    if (array[i] - array[i + 1] != -2 && array[i] - array[i + 1] < 0)
    {
        eksikNum = array[i] + 2;
       
    }
    else if (array[i] - array[i + 1] != 2 && eksikNum==0)
    {
        eksikNum = array[i] - 2;
    }
}
Console.Write(eksikNum);