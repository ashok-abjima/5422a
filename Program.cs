using System;

class Calc
{
    public int Add(int i, int j)
    {
        return i + j;
    }
    public int Add(int i, int j, int k)
    {

        return i + j + k;

    }


    public String Add(string f1, String f2)
    {
        return f1 + f2;
    }

    static void Main()
    {
        Calc ob = new Calc();
        ob.Add(1, 2);
        ob.Add("Ram", "Lakhan");
        ob.Add(10, 34, 23);
        Console.WriteLine(ob.ToString());
        Console.ReadKey();
    }
}
