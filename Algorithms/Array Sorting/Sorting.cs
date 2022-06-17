int[] array = { 22, 27, 16, 2, 18, 6 };
int tempData = 0;
for (int i = 0; i < array.Length - 1; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] > array[j])
        {
            tempData = array[i];
            array[i] = array[j];
            array[j] = tempData;
        }

    }

}
foreach (int i in array)
{
    Console.Write(i + " ");
}