using System;
using System.Reflection;

namespace NetInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== THONG TIN MOI TRUONG THUC THI .NET =====\n");

            // System.Environment
            Console.WriteLine("Phien ban .NET: " + Environment.Version);
            Console.WriteLine("Ten may tinh: " + Environment.MachineName);
            Console.WriteLine("Ten nguoi dung: " + Environment.UserName);
            Console.WriteLine("He dieu hanh: " + Environment.OSVersion);
            Console.WriteLine("Kien truc CPU: " +
                (Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit"));

            Console.WriteLine();

            // System.Reflection
            Assembly asm = Assembly.GetExecutingAssembly();
            Console.WriteLine("Ten Assembly: " + asm.GetName().Name);
            Console.WriteLine("Phien ban Assembly: " + asm.GetName().Version);

            Console.WriteLine();

            // System.GC
            long memory = GC.GetTotalMemory(false);
            Console.WriteLine("Bo nho GC dang quan ly: " +
                              memory.ToString("N0") + " bytes");

            Console.ReadKey();
        }
    }
}