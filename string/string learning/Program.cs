string email = "286507689@qq.com";
//int index = email.IndexOf("@");    // it will only find it from left to right, and only one string
//// int index = email.LastIndexOf("@")
//Console.WriteLine("@ index is ： "+ index);

//if (index < 0)
//    {
//    Console.WriteLine("format is wrong");
//    }
//else
//    {
//    Console.WriteLine("format is correct");
//    }

//string newStr = email.Substring(10);
//Console.WriteLine(newStr);

//string newStr = email.Substring(email.IndexOf("@")+1,2);  // limit the number of output
//Console.WriteLine(newStr);

//Console.WriteLine(email.ToUpper());


//"==" is used for address,  equals is for value

//if (email == "286507689@qq.com")
//{
//    Console.WriteLine("==");
//}

//string.Join("-",strs);


string[] strs = { "a ".Trim(), "b", "c" };  //delete space
string newStr = string.Join("-",strs);
string[] newStr2 = newStr.Split("-");
for (int i = 0; i < newStr2.Length; i++)
{
    Console.WriteLine(newStr2[i]);
}

string str2 = Console.ReadLine();

if (str2.Equals("asd"))
{
    Console.WriteLine("correct");
}

else
{
    Console.WriteLine("wrong");
}

Console.Read();

