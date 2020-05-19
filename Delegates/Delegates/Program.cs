using System;

namespace Delegates
{
    //Delegates It is a type of function pointer
    // a delegates holds the reference of a method and then calls the method for execution

    /*3 Steps for delegates
    1. Define Delegate
    [<modifiers>] delegate void|type <Name>([<parameter list>])
    2. Instantiating delegate
    3. Call Delegates with requird parameters

*/

        //1
    public delegate void AddDelegate(int a, int b);
    public delegate string SayDelegate(string name);
    //multicast 
    public delegate void HelloDelegate();



    class Program
    {
        static void Main(string[] args)
        {
            //instance
            Program p = new Program();
            p.AddNums(1, 2);

            //static
            Console.WriteLine(Program.StringHello("arun"));

            //2
            AddDelegate addDelegate = new AddDelegate(p.AddNums);
            SayDelegate sayDelegate = new SayDelegate(StringHello);


            Console.WriteLine("Delegates");
            addDelegate(2, 4);
            addDelegate.Invoke(10, 20);
            Console.WriteLine(sayDelegate("ARUN"));
            Console.WriteLine(sayDelegate.Invoke("Arun"));


            Console.WriteLine("Multi cast delegates");
            HelloDelegate helloDelegate = p.SayHello;
            helloDelegate += p.SayHelloWorld;
            helloDelegate();




        }

        public void AddNums(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static string StringHello(string name)
        {
            return "Hello " + name;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello People");
        }

        public void SayHelloWorld()
        {
            Console.WriteLine("Hello World");
        }
    }
}
