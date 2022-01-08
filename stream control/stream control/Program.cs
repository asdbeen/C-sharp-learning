namespace Test
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
             * 流程控制关键词
             * break 终止
             * continue 继续
             * return
             * 
             */

            //int num = 2;
            //switch(num)
            //{
            //    case 1:
            //        Console.WriteLine("case 1");
            //        break;

            //    case 2:
            //        Console.WriteLine("case 2");
            //        break ;
            //}

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine($"the first even number is {i}");
            //        break;
            //    }
            //}

            //while (true)
            //{
            //    break;
            //}
            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum = sum + i;
            //        continue; //back to i++
            //    }
            //}
            //Console.WriteLine($"sum is {sum}");
            
            //// code cant be below continue 
        }


        //private static void SayHi(string name)
        //{
        //    if(name =="zhangsan")
        //    {
        //        Console.WriteLine($"hi, {name}");
        //        return;
        //    }

        //    if (name == "lisi")
        //    {
        //        Console.WriteLine($"fuckoff, {name}");
        //    }
        //}


        private static string extractor(string fruit)
        {
            string result = fruit + "juice";

            return result;
        }


    }
}
