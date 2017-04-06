using System;

namespace HardWare
{
    class Monitor
    {
        public  void Output(Byte[] buffer)
        {
            // From byte array to string
            string s = System.Text.Encoding.UTF8.GetString(buffer, 0, buffer.Length);
            Console.WriteLine(s);
        }
    }
}


