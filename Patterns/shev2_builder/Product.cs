using System.Collections;

class Product
{
    ArrayList parts = new ArrayList();
    public void Add(string part)
    {
        parts.Add(part);
    }
    public void Show()
    {
        foreach(string part in parts)
        {
            System.Console.WriteLine(part);
        }
    }
}