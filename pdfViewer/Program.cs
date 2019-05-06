using System;

namespace pdfViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)'a');

            
        }

            static int designerPdfViewer(int[] h, string word) {
                int max  = 0;
                foreach(char c in word)
                {
                    int charHeight = h[((int)c % 32) - 1];
                    if(charHeight > max)
                    {
                        max = charHeight;
                    }
                }
                return word.Length * max;
            }

    }
}
