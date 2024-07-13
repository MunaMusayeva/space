using System;
public delegate void Func(string str);
public class MyClass
{
    private string str;
    public MyClass(string str)
    {
        this.str = str;
    }
    public void Space(string str)
    {
        string result = string.Join("_", str.ToCharArray());
        Console.WriteLine(result);
    }
    public void Reverse(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        string result = new string(charArray);
        Console.WriteLine(result);
    }
}
public class Run
{
    public void runFunc(Func func, string str)
    {
        func(str);
    }
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a string:");
        var str = Console.ReadLine();
        MyClass cls = new MyClass(str);
        Func funcDell = new Func(cls.Space);
        funcDell += new Func(cls.Reverse);
        Run run = new Run();
        run.runFunc(funcDell, str);
    }
}