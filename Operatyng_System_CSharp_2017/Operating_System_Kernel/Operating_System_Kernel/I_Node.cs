using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operating_System_Kernel
{
    class I_Node
    {
   
        File_Attributes attributes = new File_Attributes();
        ulong[] Block_Adress = new ulong[8];//es zangvaci amen mi tarri mech grvaca pa suci mi hat mec kam poqr tiv vor@ 
        //iranic nerkayacnuma fayli eterord bloki arajin bit@
        I_Node__ ref_of_next_I_Node__;

    }
}
