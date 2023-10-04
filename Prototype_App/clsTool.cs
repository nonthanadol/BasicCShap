using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_App
{
    class clsTool
    {

        public uint combineWord(int word1 , int word2) 
        {
            uint Dword = (uint)((word2 << 16) | word1);
            return Dword;
        }

        public string ConvertArrayIntToAsciiText(int[] ArrayInt)
        {
            byte[] dataBytes = new byte[ArrayInt.Length * 2];

            for (int i = 0; i < ArrayInt.Length; i++)
            {
                byte[] tempBytes = BitConverter.GetBytes((ushort)ArrayInt[i]);
                Array.Copy(tempBytes, 0, dataBytes, i * 2, 2);
            }

            string asciiText = Encoding.ASCII.GetString(dataBytes);

            return asciiText;
        }

    }
}
