using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //273;
            var name = "유" + "진" + "희";
            Console.Write("Hello"+name+"\n");//출력
            //int if= 2; 특정한 구문을 변수로 사용 X

            Console.WriteLine("Hello World");
            Console.Write("Hello World ");
            Console.Write("Hello World ");

            Console.Write(52);
            Console.WriteLine(7 % 3);
            Console.WriteLine('A');
            Console.WriteLine("A");

            Console.WriteLine("한빛\t아카데미");
            Console.WriteLine("한빛\n아카데미");
            Console.WriteLine("\"\"\"");

            //Console.WriteLine("안녕"[100]);
            Console.WriteLine("안녕"[0]);
            Console.WriteLine("안녕"[1]);

            Console.WriteLine(true);
            Console.WriteLine(!true);


        }
    }
}
