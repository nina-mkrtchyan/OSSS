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
        short Protection;
        short Read_Only;//0 or 1
        short Write_Only;//0 or 1
        short Read_Write;//0 or 1
        short Hidden;//0 or 1
        short System_File;//0 or 1
        short Size_Of_Zapis;//  ??
        ulong Create_Time_;
        ulong Last_Access;
        ulong Last_Change;
        int Current_Size;
        int Max_Size;

    }
}
