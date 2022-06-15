//Without using the hackerrank editor.
int[] a = {5,6,7};
int[] b = { 3,6,10 };
int bPoint = 0;
int aPoint = 0;
for (int i = 0; i < a.Count(); i++)
{
    if (a[i] > b[i])
    {
        aPoint++;
    }
    else if (a[i] < b[i])
    {
        bPoint++;
    }
}
Console.Write(aPoint + " " + bPoint);