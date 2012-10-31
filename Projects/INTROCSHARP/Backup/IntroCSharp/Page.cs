using System;

namespace IntroCSharp
{
   public class Page
   {
      private TextBox[] Boxes;

      private int ActiveBoxIndex = 0;

      public Page ()
      {
         this.Boxes = new TextBox[] {
            new TextBox (0, 0, 62, 5),
            new TextBox (1, 5, 30, 5),
            new TextBox (31, 5, 30, 5),
         };
      }

      public void Draw ()
      {
         for (int i = 0; i < this.Boxes.Length; i++)
         {
            this.Boxes[i].DrawContent (1);
            this.Boxes[i].DrawBorders (i != this.ActiveBoxIndex);
         }
         Console.SetCursorPosition (0, Console.BufferHeight - 1);
      }

      public void NextBox (int step)
      {
         this.Boxes[this.ActiveBoxIndex].DrawBorders (true);
         this.ActiveBoxIndex += step;
         if (this.ActiveBoxIndex < 0)
         {
            this.ActiveBoxIndex = this.Boxes.Length - 1;
         }
         else if (this.Boxes.Length - 1 < this.ActiveBoxIndex)
         {
            this.ActiveBoxIndex = 0;
         }
         this.Boxes[this.ActiveBoxIndex].DrawBorders (false);
         Console.SetCursorPosition (0, Console.BufferHeight - 1);
      }

      public void NextPage (int step)
      {
         this.Boxes[this.ActiveBoxIndex].DrawContent (step);
         Console.SetCursorPosition (0, Console.BufferHeight - 1);
      }

      public static void Main ()
      {
         Page p = new Page ();

         string[] text = new string[3];

         text[0] = string.Empty;
         for (int i = 0; i < 120; i++)
         {
            text[0] += string.Format (
               "{0}. This is a very long text. ", i);
         }
         p.Boxes[0].SetContent (text[0]);

         text[1] = string.Empty;
         for (int i = 0; i < 20; i++)
         {
            text[1] += string.Format (
               "{0}. Left column text. ", i);
         }
         p.Boxes[1].SetContent (text[1]);

         text[2] = string.Empty;
         for (int i = 0; i < 20; i++)
         {
            text[2] += string.Format (
               "{0}. Right column text. ", i);
         }
         p.Boxes[2].SetContent (text[2]);

         p.Draw ();

         ConsoleKey key;
         do
         {
            key = Console.ReadKey (true).Key;
            switch (key)
            {
               case ConsoleKey.DownArrow: p.NextBox (1); break;
               case ConsoleKey.UpArrow: p.NextBox (-1); break;
               case ConsoleKey.PageDown: p.NextPage (1); break;
               case ConsoleKey.PageUp: p.NextPage (-1); break;
            }
         }
         while (!key.Equals (ConsoleKey.Escape));
      }
   }
}

