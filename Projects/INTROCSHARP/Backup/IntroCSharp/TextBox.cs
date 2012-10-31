using System;

namespace IntroCSharp
{
   public class TextBox
   {
      private int Left, Top, Width, Height;

      private char NorthBorder = '\u2550';
      private char NorthEastBorder = '\u2557';
      private char EastBorder = '\u2551';
      private char SouthEastBorder = '\u255D';
      private char SouthBorder = '\u2550';
      private char SouthWestBorder = '\u255A';
      private char WestBorder = '\u2551';
      private char NorthWestBorder = '\u2554';

      private char NorthBorderLight = '\u2500';
      private char NorthEastBorderLight = '\u2510';
      private char EastBorderLight = '\u2502';
      private char SouthEastBorderLight = '\u2518';
      private char SouthBorderLight = '\u2500';
      private char SouthWestBorderLight = '\u2514';
      private char WestBorderLight = '\u2502';
      private char NorthWestBorderLight = '\u250C';

      private string[,] Content; // Content [page, line]

      private int ShowPage = -1;

      public TextBox (int left, int top, int width, int height)
      {
         this.Left = left + 2;
         this.Top = top + 1;
         this.Width = width - 4;
         this.Height = height - 2;
      }

      private void DrawBorders (bool singleBorders,
         int left, int top, int width, int height)
      {
         for (int j = 1; j < width - 1; j++)
         {
            Console.SetCursorPosition (left + j, top);
            Console.Write (
               singleBorders ? this.NorthBorderLight: this.NorthBorder);
         }
         for (int j = 1; j < width - 1; j++)
         {
            Console.SetCursorPosition (left + j, top + height - 1);
            Console.Write (
               singleBorders ? this.SouthBorderLight: this.SouthBorder);
         }
         for (int i = 1; i < height - 1; i++)
         {
            Console.SetCursorPosition (left, top + i);
            Console.Write (
               singleBorders ? this.WestBorderLight: this.WestBorder);
         }
         for (int i = 1; i < height - 1; i++)
         {
            Console.SetCursorPosition (left + width - 1, top + i);
            Console.Write (
               singleBorders ? this.EastBorderLight: this.EastBorder);
         }
         Console.SetCursorPosition (left, top);
         Console.Write (
               singleBorders ? this.NorthWestBorderLight: this.NorthWestBorder);
         Console.SetCursorPosition (left + width - 1, top);
         Console.Write (
               singleBorders ? this.NorthEastBorderLight: this.NorthEastBorder);
         Console.SetCursorPosition (left, top + height - 1);
         Console.Write (
               singleBorders ? this.SouthWestBorderLight: this.SouthWestBorder);
         Console.SetCursorPosition (left + width - 1, top + height - 1);
         Console.Write (
               singleBorders ? this.SouthEastBorderLight: this.SouthEastBorder);
         Console.WriteLine ();
      }

      private void BreakLine (string line, ref int countBreaks,
                              bool copyToContent)
      {
         int startIndex = 0, breakIndex = this.Width - 1;
         while (breakIndex < line.Length)
         {
            int lastSpaceIndex = line.LastIndexOf(' ', breakIndex,
               breakIndex - startIndex + 1);
            if (lastSpaceIndex > -1)
            {
               breakIndex = lastSpaceIndex;
            }
            if (copyToContent)
            {
               int pageIndex = countBreaks / this.Height;
               int lineIndex = countBreaks % this.Height;

               this.Content [pageIndex, lineIndex] = line.Substring (
                  startIndex, breakIndex - startIndex + 1);
            }
            countBreaks++;
            startIndex = breakIndex + 1;
            breakIndex += this.Width;
         }
         if (startIndex < line.Length)
         {
            if (copyToContent)
            {
               int pageIndex = countBreaks / this.Height;
               int lineIndex = countBreaks % this.Height;

               this.Content [pageIndex, lineIndex] = line.Substring (
                  startIndex);
            }
            countBreaks++;
         }
      }

      private int BreakLines (string[] lines, bool copyToContent)
      {
         int countBreaks = 0;
         foreach (string line in lines)
         {
            this.BreakLine (line, ref countBreaks, copyToContent);
         }
         return countBreaks;
      }

      private int CountPageBreaks (string[] lines)
      {
         int linesCount = this.BreakLines (lines, false);
         int extraPage = (linesCount % this.Height > 0 ? 1 : 0);
         return linesCount / this.Height + extraPage;
      }

      private void PadLines ()
      {
         int pageCount = this.Content.GetLength (0);
         int lineCount = this.Content.GetLength (1);
         for (int pageIndex = 0; pageIndex < pageCount; pageIndex++)
         {
            for (int lineIndex = 0; lineIndex < lineCount; lineIndex++)
            {
               if (this.Content[pageIndex, lineIndex] == null)
               {
                  this.Content[pageIndex, lineIndex] = string.Empty;
               }
               this.Content[pageIndex, lineIndex] =
                  this.Content[pageIndex, lineIndex].PadRight (this.Width);
            }
         }
      }

      public void SetContent (string text)
      {
         string[] separators = new string[] {Environment.NewLine};
         StringSplitOptions splitOption = StringSplitOptions.None;
         string[] lines = text.Replace("\t", "   ")
            .Split (separators, splitOption);
         int pageCount = this.CountPageBreaks (lines);
         this.Content = new string[pageCount, this.Height];
         this.BreakLines (lines, true);
         this.PadLines ();
      }

      public void SetContent (string format, params object[] args)
      {
         this.SetContent (string.Format (format, args));
      }

      public void SetContent (object[] vector, string cellFormat)
      {
         string text = string.Empty;
         for (int i = 0; i < vector.Length; i++)
         {
            text += string.Format (cellFormat, vector[i]);
         }
         text += Environment.NewLine;
         this.SetContent (text);
      }

      public void SetContent (object[,] matrix, string cellFormat)
      {
         string text = string.Empty;
         for (int i = 0; i < matrix.GetLength (0); i++)
         {
            for (int j = 0; j < matrix.GetLength (1); j++)
            {
               text += string.Format (cellFormat, matrix[i, j]);
            }
            text += Environment.NewLine;
         }
         this.SetContent (text);
      }

      public void DrawBorders (bool singleBorders)
      {
         this.DrawBorders (singleBorders, this.Left - 2, this.Top - 1,
           this.Width + 4, this.Height + 2);
      }

      public void DrawContent (int step = 1)
      {
         this.ShowPage += step;
         if (this.ShowPage < 0)
         {
            this.ShowPage = this.Content.GetLength (0) - 1;
         }
         else if (this.ShowPage > this.Content.GetLength (0) - 1)
         {
            this.ShowPage = 0;
         }
         if (0 < this.Content.GetLength (0))
         {
            for (int i = 0; i < this.Height; i++)
            {
               Console.SetCursorPosition (this.Left, this.Top + i);
               Console.Write (this.Content[this.ShowPage, i]);
            }
         }
      }
   }
}

