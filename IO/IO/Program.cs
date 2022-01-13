//System.IO
//Difference between xxxinfo and xxx(static)

class Program
{
    static void Main(string[] args)
    {
        #region FileInfo and File
        //// create file
        //FileInfo file = new FileInfo(@"C:\Users\User\Desktop\C# learning\IO\\output1\Test.txt");
        //FileStream fs =file.Create();

        //// close file
        //fs.Close();
        //Console.WriteLine("created time: " + file.CreationTime);
        //Console.WriteLine("address: " + file.DirectoryName);

        ////open streamwriter
        //StreamWriter sw = file.AppendText();

        ////add text
        //sw.Write("czb");

        ////close

        //sw.Dispose();

        ////move
        //File.Move(file.FullName, @"C:\Users\User\Desktop\C# learning\IO\\output2\Test.txt");
        //Console.WriteLine("succeed");
        //Console.Read();

        #endregion


        #region DirectoryInfo and Directory
        //Create folder
        DirectoryInfo directory = new DirectoryInfo(@"C:\Users\User\Desktop\C# learning\IO\new folder");
        directory.Create();
        Console.WriteLine("Parent: " + directory.Parent.FullName);

        //Output

    }
}