int[] array = { 3, 6, 12, 66, 0, -4, 3 };

int tempData = 0;
int minNumber = 0;

for(int i = 0; i < array.Length-1; i++)
{
    minNumber = i;
    for (int j = i+1; j<array.Length; j++)
    {
        if (array[j] < array[minNumber])
        {
            minNumber = j;
        }
    }

    tempData = array[i];
    array[i] = array[minNumber];
    array[minNumber] = tempData;

}
foreach(int i in array)
{
    Console.Write(i+ " ");
}