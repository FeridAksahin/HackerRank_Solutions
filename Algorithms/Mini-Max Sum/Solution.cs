//Without using the hackerrank editor.

Console.WriteLine("Dizi lengh");
int len = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[len];

for (int i = 0; i < len; i++)
{
    Console.WriteLine("Enter {0}. array number", i + 1);
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

Array.Sort(arr);
foreach (int i in arr)
{
    Console.WriteLine(i);
}//1 2 3 4 5 
int maxSum = 0;
foreach (int i in arr)
{
    if (i > arr[0])
    {
        maxSum += i;
    }
}

int minSum = 0;
foreach (int i in arr)
{
    if (i < arr[len-1])
    {
        minSum += i;
    }
}

int[] answerArray = { minSum, maxSum }; 

foreach(int i in answerArray)
{
    Console.Write(i + " ");
}