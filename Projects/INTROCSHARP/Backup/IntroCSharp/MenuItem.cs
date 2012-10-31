using System;

namespace IntroCSharp
{
   public delegate void Sub ();

   public class MenuItem
   {
      public Sub Method;

      public string Description;

      public ConsoleKey Key;

      public MenuItem (Sub method,
                       string description,
                       ConsoleKey key)
      {
         this.Method = method;
         this.Description = description;
         this.Key = key;
      }

      public MenuItem (Sub method,
                       string description)
      {
         this.Method = method;
         this.Description = description;
         this.Key = ConsoleKey.NoName;
      }
   }
}

