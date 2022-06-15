//Program to find the average of n numbers entered with using arrays

Console.WriteLine("Enter array length: ");
int arrayLength = int.Parse(Console.ReadLine());
int[] array = new int[arrayLength];

for (int i = 0; i < arrayLength; i++)
{
    Console.WriteLine("Enter {0}. number", i + 1);
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int sum = 0;
foreach (var i in array)
    sum += i;

Console.WriteLine("Avarage = " + sum / arrayLength);

/* without using foreach
   
Console.WriteLine("Enter array length: ");
int arrayLength = int.Parse(Console.ReadLine());
int[] array = new int[arrayLength];
int sum = 0;
for (int i = 0; i < arrayLength; i++)
{
    Console.WriteLine("Enter {0}. number", i+1);
    array[i] = Convert.ToInt32(Console.ReadLine());
    sum += array[i];
}

Console.WriteLine("Avarage = " + sum / arrayLength);

 */
