using System;

namespace Lift
{
    class Program
    {
        static void Main(string[] args)
        {
           int LiftStart=1, LiftEnd,LiftEnd1,LiftEnd2;
            
            Console.WriteLine("-----------------My Lift----------------");
        
            Console.Write("where you are heading?");
           
            LiftEnd=Int32.Parse(Console.ReadLine());

            for(int i=1;i<=LiftEnd;i++)
            {
                Console.WriteLine(i);
        
                System.Threading.Thread.Sleep(1500);
            }
                Console.Beep();

            Console.Write("where you are heading?");
            LiftEnd1=Int32.Parse(Console.ReadLine());
           
            if(LiftEnd<LiftEnd1)
            
                for(;LiftEnd<=LiftEnd1-1;LiftEnd++)
                {
                    Console.WriteLine(LiftEnd+1);
                    System.Threading.Thread.Sleep(1500);
                } 
                                         
                else
                 {
                    for(;LiftEnd-1>=LiftEnd1;LiftEnd--)
                   {
                      Console.WriteLine(LiftEnd-1);
                      System.Threading.Thread.Sleep(1500);
                    }
                  Console.Beep();
                  }
                  Console.Write("where you are heading?");
                  LiftEnd2=Int32.Parse(Console.ReadLine());
        
        if(LiftEnd1<LiftEnd2)
            
                for(;LiftEnd1<=LiftEnd2-1;LiftEnd1++)
                {
                    Console.WriteLine(LiftEnd1+1);
                    System.Threading.Thread.Sleep(1500);
                } 
                                         
                else
                 {
                    for(;LiftEnd1-1>=LiftEnd2;LiftEnd1--)
                   {
                      Console.WriteLine(LiftEnd1-1);
                      System.Threading.Thread.Sleep(1500);
                    }
                  Console.Beep();
        }

        }
    }   
}
