namespace CSharp4._0._2.NamedArguments
{
    public class Example
    {
        public static void MyPrint() => global::System.Console.WriteLine("Using global alias");
    }

    public class Console
    {
        public static void WriteLine(string param)
        {
            global::System.Console.WriteLine("Consiger renaming this class");
        }
    }
}
