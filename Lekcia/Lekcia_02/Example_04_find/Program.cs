int[] massif = { 1, 2, 73, 94, 58, 6, 72, 81, 2 };
int n = massif.Length;
int find = 2;

int index = 0;

while (index < n)
{
    if (massif[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}