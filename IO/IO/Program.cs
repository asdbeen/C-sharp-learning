//System.IO
//Difference between xxxinfo and xxx(static)
//https://blog.csdn.net/qq_45533800/article/details/105744255
//https://programmer.help/blogs/c-io-stream-and-file-read-write-learning-notes.html
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
        ////Create folder
        //DirectoryInfo directory = new DirectoryInfo(@"C:\Users\User\Desktop\C# learning\IO\new folder");
        //directory.Create();
        //Console.WriteLine("Parent: " + directory.Parent.FullName);

        ////Output
        //FileSystemInfo[] infos = directory.Parent.GetFileSystemInfos();
        //foreach (FileSystemInfo info in infos)
        //{
        //    Console.WriteLine(info.FullName);
        //}



        ////delect
        //Directory.Delete(directory.FullName);
        //Console.WriteLine("succeed");
        //Console.Read();
        #endregion

        #region Path

        ////connection
        //Console.WriteLine(Path.Combine(@"C:\Users\User\Desktop\", @"C# learning\IO\output2\Test.txt"));
        //Console.WriteLine("char: " + Path.DirectorySeparatorChar);
        //Console.WriteLine("char replaced: " + Path.AltDirectorySeparatorChar);
        //Console.Read();
        #endregion

        #region DriveInfo
        //DriveInfo[] drives = DriveInfo.GetDrives();
        //foreach (DriveInfo drive in drives)
        //{
        //    if (drive.IsReady)
        //    {
        //        Console.WriteLine("name of driver: " + drive.Name);
        //        Console.WriteLine("type of driver: " + drive.DriveFormat);
        //        Console.WriteLine("total space: " + drive.TotalFreeSpace);
        //        Console.WriteLine("availa space: " + drive.AvailableFreeSpace);
        //    }
        //}
        //Console.Read();
        #endregion

        #region file move-dupilicate-move

        //string path = @"C:\Users\User\Desktop\C# learning\IO\output2\Test.txt";

        //File.WriteAllText(path, "test info");
        //Console.WriteLine("file has been written");

        //File.Move(path, @"C:\Users\User\Desktop\C# learning\IO\output1\Test.txt");
        //Console.WriteLine("file has been moved");

        //File.Copy(@"C:\Users\User\Desktop\C# learning\IO\output1\Test.txt", path);
        //Console.WriteLine("file has been copied");

        //File.Delete(@"C:\Users\User\Desktop\C# learning\IO\output1\Test.txt");
        //Console.WriteLine("file has been deleted");

        //Console.Read();
        #endregion

        #region  classify file and folder

        //IsFile(@"C:\Users\User\Desktop\C# learning\IO\output2\Test.txt");
        //IsFile(@"C:\Users\User\Desktop\C# learning\IO\output2");
        //IsFile(@"C:\Users\User\Desktop\C# learning\IO");



        //static void IsFile(string path)
        //{
        //    if (File.Exists(path))
        //    {
        //        Console.WriteLine("its a file");
        //    }

        //    else if (Directory.Exists(path))
        //    {
        //        Console.WriteLine("its a folder");
        //    }

        //    else
        //    {
        //        Console.WriteLine("path doesnt exist");
        //    }
        //}

        #endregion

        #region load file

        //string path = @"C:\Users\User\Desktop\C# learning\IO\output2\Test.txt";
        //byte[] bytes = File.ReadAllBytes(path);
        //Console.WriteLine("ReadAllBytes: ");
        //Console.WriteLine("{0}",bytes.Length);
        //Console.WriteLine("{0}", bytes[0]);
        //foreach (byte b in bytes)
        //{
        //    Console.Write(b);
        //}
        //Console.WriteLine(Environment.NewLine);

        //string[] strs = File.ReadAllLines(path,System.Text.Encoding.UTF8);
        //Console.WriteLine("ReadAllLines: ");
        //foreach (string s in strs)
        //{
        //    Console.WriteLine(s + "\n");
        //}

        //string str = File.ReadAllText(path, System.Text.Encoding.UTF8);
        //Console.WriteLine("ReadAllText:\n"+str);
        //Console.Read();

        #endregion

        #region file write

        //string path = @"C:\Users\User\Desktop\C# learning\IO\output2\Test.txt";
        //File.WriteAllBytes(path, new byte[] {0,1,2,3,4,5,6,7,8,9});
        //Console.WriteLine("WriteAllBytes sucessfully");

        //string[] array = { "123", "456", "789" };
        //File.WriteAllLines(path, array,System.Text.Encoding.UTF8);
        //Console.WriteLine("WriteAllLines sucessfully");

        //File.WriteAllText(path, "Hello World", System.Text.Encoding.UTF8);
        //Console.WriteLine("WriteAllText sucessfully");

        //Console.Read();
        #endregion

        //datastream
        // FileStream - StreamReader - StreamWriter - BufferedStream:

        #region use FileStream to read and write binary file
        //string path = @"C:\Users\User\Desktop\C# learning\IO\output2\Test2.txt";

        ////create a file by writing a file
        //FileStream file = new FileStream(path, FileMode.CreateNew, FileAccess.Write);
        //string str = "asd";
        //byte[] bytes = System.Text.Encoding.Unicode.GetBytes(str);

        ////write binary
        //file.Write(bytes, 0, bytes.Length);
        //file.Dispose();
        //Console.WriteLine("succeed");

        ////open file with read-only
        //file = new FileStream(path,FileMode.Open, FileAccess.Read);
        //byte[] temp = new byte[bytes.Length];

        ////read binary
        //file.Read(temp, 0, temp.Length);
        //Console.WriteLine("read data： " + System.Text.Encoding.Unicode.GetString(temp));
        //file.Dispose();
        //Console.Read();
        #endregion


        #region StreamWriter and StreamReader
        //string path = @"C:\Users\User\Desktop\C# learning\IO\output2\Test1.txt";

        ////create file by writing

        //FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
        //StreamWriter sw = new StreamWriter(file);
        //sw.WriteLine("Asd");
        //sw.Dispose();
        //Console.WriteLine("succeed");

        ////open file read-only

        //file = new FileStream(path, FileMode.Open, FileAccess.Read);
        //StreamReader sr = new StreamReader(file);
        //Console.WriteLine("read data:" + sr.ReadToEnd());
        //sr.Dispose();
        //Console.Read();
        #endregion


        #region MemoryMappedFile
        //System.IO.MemoryMappedFiles.MemoryMappedFile mmFile = System.IO.MemoryMappedFiles.MemoryMappedFile.CreateFromFile(@"C:\Users\User\Desktop\C# learning\IO\output2\Test.txt", FileMode.OpenOrCreate, "MapName", 1024 * 1024);
        ////view of MemoryMapped
        ////use datastream to control memoryfile  MemoryMappedViewStream stream = mmFile.CreateViewStream();
        //System.IO.MemoryMappedFiles.MemoryMappedViewAccessor mmViewAccessor = mmFile.CreateViewAccessor();
        //string str = "ASD";
        //int length =System.Text.Encoding.UTF8.GetByteCount(str);

        ////write data
        //mmViewAccessor.WriteArray<byte>(0, System.Text.Encoding.UTF8.GetBytes(str), 0, length);
        //byte[] bytes = new byte[length];
        //mmViewAccessor.ReadArray<byte>(0, bytes, 0, length);
        //Console.WriteLine(System.Text.Encoding.UTF8.GetString(bytes));

        ////release resource 
        //mmFile.Dispose();
        //Console.Read();
        #endregion


        #region read ACL
        //FileStream file = new FileStream(@"C:\Users\User\Desktop\C# learning\IO\output2\Test.txt", FileMode.Open, FileAccess.Read);

        ////get the file property
        //System.Security.AccessControl.FileSecurity filesec = file.GetAccessControl();

        ////output
        //foreach (System.Security.AccessControl.FileSystemAccessRule filerule in filesec.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount)))
        //    {
        //    Console.WriteLine(filerule.AccessControlType + "- -" + filerule.FileSystemRights + "- -" + filerule.IdentityReference);
        //    }
        //file.Dispose();
        //Console.Read();

        #endregion

        #region edit ACL

        FileStream file = new FileStream(@"C:\Users\User\Desktop\C# learning\IO\output2\Test.txt",FileMode.Open,FileAccess.Read);

        //get the file property
        System.Security.AccessControl.FileSecurity filesec = file.GetAccessControl();

        //output

        void PrintACL(System.Security.AccessControl.AuthorizationRuleCollection x)
        {
            foreach (System.Security.AccessControl.FileSystemAccessRule filerule in filesec.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount)))
            {
            Console.WriteLine(filerule.AccessControlType + "- -" + filerule.FileSystemRights + "- -" + filerule.IdentityReference);
            }
        }

        PrintACL(filesec.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount)));

        #endregion
    }




}




