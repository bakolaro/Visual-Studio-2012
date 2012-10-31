using System;

namespace IntroCSharp
{
   class MainClass: Menu
   {
      public MainClass (): base ()
      {
         this.MenuTitle = "Main Menu. Choose an option...";
         
         this.Options = new MenuItem[] {
            new MenuItem (Chapter01.Run,
                       "Chapter 1 - Introduction."),
            new MenuItem (Chapter02.Run,
                       "Chapter 2 - Primitive data types."),
            new MenuItem (Chapter03.Run,
                       "Chapter 3 - Operators and expressions."),
            new MenuItem (Chapter04.Run,
                       "Chapter 4 - Console operations."),
            new MenuItem (Chapter05.Run,
                       "Chapter 5 - Control structures."),
            new MenuItem (Chapter06.Run,
                       "Chapter 6 - Loops."),
            new MenuItem (new Chapter07 ().Run,
                       "Chapter 7 - Arrays."),
            new MenuItem (new Chapter08 ().Run,
                       "Chapter 8 - Numeral systems."),
            new MenuItem (new Chapter09 ().Run,
                       "Chapter 9 - Methods."),
            new MenuItem (new Chapter10 ().Run,
                       "Chapter 10 - Recursion.")
         };
      }
   }
}
