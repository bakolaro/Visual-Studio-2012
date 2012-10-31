using System;

namespace IntroCSharp
{
   public abstract class Menu: TextBoxingAndPaging
   {
      public string MenuTitle;

      public MenuItem[] Buttons, Options;

      public int SelectedOption;

      public bool IsOver = false;

      public Menu ()
      {
         this.Buttons = new MenuItem[]  {
         new MenuItem (this.Quit, "Quit menu",
            ConsoleKey.Escape),
         new MenuItem (this.Exec, "Execute option",
            ConsoleKey.Enter),
         new MenuItem (this.Down, "Next option",
            ConsoleKey.DownArrow),
         new MenuItem (this.Up, "Previous option",
            ConsoleKey.UpArrow)
         };
      }

      public void DisplayTitle ()
      {
         this.DisplayText (true, this.MenuTitle);
      }

      public void DisplayButtons ()
      {
         for (int i = 0; i < this.Buttons.Length; i++)
         {
            this.DisplayText (false, this.Buttons[i].Description +
               " <" + this.Buttons[i].Key.ToString () + ">");
         }
         Console.WriteLine ();
      }

      public void DisplayOptions ()
      {
         for (int i = 0; i < this.Options.Length; i++)
         {
            this.DisplayText (
               i == this.SelectedOption, this.Options[i].Description);
         }
      }

      public void Exec ()
      {
         Console.Clear ();
         Console.WriteLine ();
         this.DisplayedLines = 0;
         this.DisplayTitle ();

         this.Options[this.SelectedOption].Method ();
      }

      public void Down ()
      {
         this.SelectedOption++;
         if (this.SelectedOption > this.Options.Length - 1)
         {
            this.SelectedOption = 0;
         }
      }

      public void Up ()
      {
         this.SelectedOption--;
         if (this.SelectedOption < 0)
         {
            this.SelectedOption = this.Options.Length - 1;
         }
      }

      public void Quit ()
      {
         this.IsOver = true;
      }

      public void Run ()
      {
         Console.Clear ();
         Console.WriteLine ();

         this.LastStopBeforeLine = this.DisplayedLines;

         this.DisplayTitle ();
         this.DisplayButtons ();
         this.DisplayOptions ();

         ConsoleKey key = Console.ReadKey (true).Key;

         foreach (MenuItem item in this.Buttons)
         {
            if (item.Key.Equals (key))
            {
               item.Method ();
               break;
            }
         }

         if (!this.IsOver)
         {
            this.Run ();
         }
      }
   }
}