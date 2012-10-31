using System;

namespace IntroCSharp
{
   public class Pause: Menu
   {
      public Pause ()
      {
         this.DisplayText (false, NL +
            "Press a key to continue...");
         Console.ReadKey (true);
      }

      public Pause (bool endOfPage)
      {
         if (endOfPage)
         {
            this.DisplayText (false, NL +
               "Press a key to continue, <Esc> to quit...");

            if (Console.ReadKey (true).Key.Equals (ConsoleKey.Escape))
            {
               this.IsOver = true;
            }
            else
            {
               Console.Clear ();
            }
         }
      }
   }
}

