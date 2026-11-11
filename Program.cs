namespace RefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string path, d, msgErr;
            int sum=0;
            path = Console.ReadLine();
            path = path.Trim().Trim('"');
             d= Path.Combine(Path.GetDirectoryName(path), "new folder");
            teacher t= new teacher();
            t.fun1(d, path,out msgErr,ref sum);

        }
    }
}
