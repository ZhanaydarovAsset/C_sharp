void Method(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method("sms", 5);

int Method2()
{
    return DateTime.Now.Year;
}
int god = Method2();
//Console.WriteLine(god);


string Method3(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method3(5, "f");
Console.WriteLine(res);
