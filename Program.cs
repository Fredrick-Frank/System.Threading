using System;
using System.Text;
using System.Threading;

namespace ConsoleAp
{
    class ThreadingCreationProgram
    {
        
        public static void CallToChildThread()
        {
            //Console.WriteLine("Child thread starts");
        }
        
        static void Main()
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main: Creating the Child thread");
            
            Thread childThread = new Thread(childref);
            childThread.Start();
            Console.ReadKey();
        }
    }
}