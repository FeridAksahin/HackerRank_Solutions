Console.WriteLine("Enter array length: ");
int arrayLength = int.Parse(Console.ReadLine());
int[] array = new int[arrayLength];

for(int i = 0; i < arrayLength; i++)
{
    Console.WriteLine("Enter {0}. array number", i+1);
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int b = 0;
foreach(int i in array)
{
    b = i + b;
}

Console.WriteLine("Array sum = "+ b);