
///<summary>
///класс отвечающий за вставку в массив
///</summary>
public static class InsertArray
{
    
    public static void Insert (ref string[] array, string value, int index = 0)
    {
        string[] newArray = new string[array.Length +1];
        newArray[index] = value;
        for (int i = 0; i < index; i++)
            newArray[i] = array[i];
        for (int i = index; i < array.Length; i++)
            newArray[i+1] = array[i];
        array = newArray;
    }
}