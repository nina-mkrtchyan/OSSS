using System;
using System.Text;
using System.Threading.Tasks;

namespace HardWare
{
    class KeyBoard
    {
        public byte[] Buffer {private set; get; }

        public byte[] Input()
        {
            // From string to byte array
             Buffer = System.Text.Encoding.UTF8.GetBytes(Console.ReadLine());
            return Buffer;
        }

    }
}
