using System;
using System.Text;

namespace MyStringTools
{
    public class StringTools
    {
        public static int CountDigits(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (Char.GetNumericValue(c) != -1.0)
                {
                    count++; 
                }
            }

            return count;
        }

        static public byte[] GetAsciiCodes(string str)
        {
            ASCIIEncoding ascii = new ASCIIEncoding();
            byte[] cs = new byte[str.Length];
            cs = ascii.GetBytes(str);
            return cs;
        }

        static public string GetHexadecimalAsciiString(string str)
        {
            string hexChar = "";
            string result = "";

            foreach (char c in str)
            {
                hexChar = Convert.ToString(Uri.HexEscape(c));
                result = result + hexChar.Substring(1, hexChar.Length - 1) + " ";
            }
            return result.Substring(0, result.Length - 1);
        }
    }
}
