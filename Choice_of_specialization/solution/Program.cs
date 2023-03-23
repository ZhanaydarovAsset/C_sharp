//
using static InsertArray;

string[] array = {"window", "bmw", "gb", "turan"};
string [] massif = {};
for (int i = 0; i < array.Length; i++)
{
    string temp = String.Empty;
    if(array[i].Length<=3)
    {
         temp = array[i];
         Insert(ref massif, temp);
    }
}

Console.WriteLine($"[{String.Join(",", massif)}]");
