using System;

namespace IntroCSharp
{
   public class TextBoxingAndPaging
   {
      private char[] NorthBorder = {'\u2500'};
      private char[] NorthEastBorder = {'\u2510'};
      private char[] EastBorder = {' ', '\u2502'};
      private char[] SouthEastBorder = {'\u2518'};
      private char[] SouthBorder = {'\u2500'};
      private char[] SouthWestBorder = {'\u2514'};
      private char[] WestBorder = {'\u2502', ' '};
      private char[] NorthWestBorder = {'\u250C'};

      private string[] TextToLines (string text)
      {
         string[] separators = new string[] {Environment.NewLine};
         int lengthOfEveryLine = Console.BufferWidth
            - this.WestBorder.Length - this.EastBorder.Length;

         int indexOfRestOfText = 0;
         string newText = string.Empty;

         while (indexOfRestOfText < text.Length)
         {
            string line;
            if (indexOfRestOfText + lengthOfEveryLine < text.Length)
            {
               line = text.Substring (indexOfRestOfText, lengthOfEveryLine);

               // do not break words
               if (line.IndexOf (" ") > -1)
               {
                  if (!line.EndsWith (" "))
                  {
                     string nextLine = text
                        .Substring (indexOfRestOfText + lengthOfEveryLine);
                     if (!nextLine.StartsWith (" "))
                     {
                        line = line
                           .Substring (0, line.LastIndexOf (" ") + 1);
                     }
                  }
               }
            }
            else
            {
               line = text.Substring (indexOfRestOfText);
            }

            indexOfRestOfText += line.Length;
            newText += line.PadRight (lengthOfEveryLine);
            if (indexOfRestOfText < text.Length)
            {
               newText += Environment.NewLine;
            }
         }

         return newText.Split (separators, StringSplitOptions.None);
      }

      private string MatrixToText(string cellFormat, object[,] matrix)
      {
         string newText = string.Empty;
         for (int i = 0; i < matrix.GetLength (0); i++)
         {
            for (int j = 0; j < matrix.GetLength (1); j++)
            {
               newText += string.Format (cellFormat, matrix[i, j]);
            }
            newText += Environment.NewLine;
         }
         return newText;
      }

      private string VectorToText(string cellFormat, object[] vector)
      {
         string newText = string.Empty;
         for (int i = 0; i < vector.Length; i++)
         {
            newText += string.Format (cellFormat, vector[i]);
         }
         newText += Environment.NewLine;
         return newText;
      }

      private string TextToText(string format, object[] args)
      {
         return string.Format (format, args);
      }

      public string NL = Environment.NewLine;

      public int DisplayedLines, LastStopBeforeLine;

      public TextBoxingAndPaging ()
      {
         Console.Clear ();
         Console.WriteLine ();
         DisplayedLines = LastStopBeforeLine = 1;
      }

      private bool DisplayText (string[] lines)
      {
         foreach (string line in lines)
         {
            Console.WriteLine (line);
            this.DisplayedLines++;

            if (this.DisplayedLines - this.LastStopBeforeLine
                == Console.BufferHeight - 2)
            {
               this.LastStopBeforeLine = this.DisplayedLines;
               this.DisplayText (false, NL +
                  "Press a key to continue, <Esc> to quit...");

               if (Console.ReadKey (true).Key.Equals (ConsoleKey.Escape))
               {
                  return false;
               }
               else
               {
                  Console.Clear ();
               }
            }
         }
         return true;
      }

      public void DisplayText (bool drawBox, string format,
                               params object[] args)
      {
         string f = string.Format (format, args);
         string[] lines = this.TextToLines (f);
         this.DisplayText (this.LinesInBox (lines, drawBox));
      }

      public bool DisplayText (string format, object[,] array)
      {
         string lineText;
         for (int i = 0; i < array.GetLength (0); i++)
         {
            lineText = string.Empty;
            for (int j = 0; j < array.GetLength (1); j++)
            {
               lineText += string.Format (format, array[i, j]);
            }
            if (!this.DisplayText (new string[]{lineText}))
            {
               return false;
            }
         }
         return true;
      }

      private string[] LinesInBox (string[] lines, bool border)
      {
         int textBoxLinesCount = border ?
            this.NorthBorder.Length + lines.Length + this.SouthBorder.Length :
            lines.Length;

         string[] textBoxLines = new string[textBoxLinesCount];

         int lineIndex = 0;
         string lineText;

         if (border)
         {
            // NW.Length == N.Length == NE.Length
            for (int i = 0; i < this.NorthBorder.Length; i++)
            {
               lineText = this.NorthWestBorder[i] + string.Empty.PadRight (
                  Console.BufferWidth - this.NorthWestBorder.Length - this.NorthEastBorder.Length,
                  this.NorthBorder[i]) + this.NorthEastBorder[i];
               textBoxLines[lineIndex++] = lineText;
            }
         }
         // line.Length == const
         foreach (string line in lines)
         {
            lineText = string.Empty;
            for (int i = 0; i < this.WestBorder.Length; i++)
            {
               lineText += (border ? this.WestBorder[i] : ' ');
            }
            lineText += line;
            for (int i = 0; i < this.EastBorder.Length; i++)
            {
               lineText += (border ? this.EastBorder[i] : ' ');
            }
            textBoxLines[lineIndex++] = lineText;
         }
         if (border)
         {
            // SW.Length == S.Length == SE.Length
            for (int i = 0; i < this.SouthBorder.Length; i++)
            {
               lineText = this.SouthWestBorder[i] + string.Empty.PadRight (
                  Console.BufferWidth - this.SouthWestBorder.Length - this.SouthEastBorder.Length,
                  this.SouthBorder[i]) + this.SouthEastBorder[i];
               textBoxLines[lineIndex++] = lineText;
            }
         }

         return textBoxLines;
      }


      public void Test ()
      {
         int a, b, c;
         a = 1;
         b = 2;
         c = 3;
         this.DisplayText (false, "{0}+{1}={2}", a, b, c);

         this.DisplayText (false, "{{0}}+{{1}}={{2}}");

         this.DisplayText (false, "{0}, {2}", new object[]{a, b, c});

         this.DisplayText ("{0}; ", new object[,]{{a, b, c}});

         this.DisplayText (true, "{0}",
            "This is a very long text. This is a very long text." +
            " This is a very long text. This is a very long text." +
            " This is a very long text. This is a very long text." +
            " This is a very long text. This is a very long text.");

         this.DisplayText (true, "{0}",
            "This is a very long text. This is a very long text." +
            " This is a very long text. This is a very long text." +
            " This is a very long text. This is a very long text." +
            " This is a very long text. This is a very long text. ".PadRight (1000, '*'));

         this.DisplayText ("{0}; ", new object[60,60]);
      }
   }
}