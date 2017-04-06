using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operating_System_Kernel
{
    class File_Attributes
    {

        //atributner@ klinenenenen
        byte Protection;
        byte Read_Only;//0 or 1 
        byte Write_Only;//0 or 1
        byte Read_Write;//0 or 1
        byte Hidden;//0 or 1
        byte System_File;//0 or 1
        short Size_Of_Zapis;//  ??
        ulong Create_Time_;
        ulong Last_Access;
        ulong Last_Change;
        int Current_Size;
        int Max_Size;

    }
}
