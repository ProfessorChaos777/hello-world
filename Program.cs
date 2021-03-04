using System;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
namespace myproject2
{
    class Program
    {
     
          public static void Count()
    {
        for(int i=0;i<9999999;i++)
{
   int yu=0;
  yu++;
            
}
       
    }
         static int x=0;
        static void Main(string[] args)
        {


   for(int i=0;i<999;i++)
{
            Task myThread = new Task(Count);
          //  myThread.Name = "Поток " + i.ToString();
           myThread.Start();
        }



  foreach(Process process in Process.GetProcesses())
{
    // выводим id и имя процесса
    if (process.ProcessName=="dotnet")
    {
    foreach( ProcessThread a in process.Threads)
    {
  Console.WriteLine("ID:{0} state:{1}",a.Id,a.ThreadState);

    }

    }
    }
    }
}
}
 
 