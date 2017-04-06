using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operating_System_Kernel
{
    class Super_Block
    {
        //es bolor dashteri arjeqner@ petqa voroshenq u tenanq ete kan nencner@ vronq petq chen hanenq

        ulong s_inodes_count=10000;
       // i-nod-eri qanak

        ulong s_blocks_count;//Число индексных дескрипторов в файловой системе

        ulong s_blocks_count_for_Super_User;//Число блоков, зарезервированных для суперпользователя

        ulong s_free_blocks_count;//Счетчик числа свободных блоков	
 
        ulong s_free_index_Descriptors_Count;//Счетчик числа свободных индексных дескрипторов	 

        // ulong s_first_data_block;//Первый блок, который содержит данные.
        //В зависимости от размера блока, это поле может быть равно 0 или 1	 

        // ulong s_log_block_size;//Индикатор размера логического блока: 0 = 1 Кб; 1 = 2 Кб; 2 = 4 Кб	 
	 
        ulong s_blocks_per_group;//Число блоков в каждой группе блоков	 ?
        ulong s_frags_per_group;//Число фрагментов в каждой группе блоков	? 
        ulong s_inodes_per_group;//Число индексных дескрипторов (inodes) в каждой группе блоков	 ?   	
        ushort s_errors;	//Флаги, задающие процедуры обработки сообщений об ошибках (что делать, если найдены ошибки)	 
        ulong s_rev_level;//Версия (revision level) файловой системы	 

        //ulong s_reserved;//ULONG[235]	//Заполнение до 1024 байт

    }
}
