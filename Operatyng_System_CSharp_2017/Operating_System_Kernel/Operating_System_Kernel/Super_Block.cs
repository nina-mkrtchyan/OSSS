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

        ulong s_inodes_count;
       // Число индексных дескрипторов в файловой системе

        ulong s_blocks_count;//Число индексных дескрипторов в файловой системе

        ulong s_blocks_count;//Число блоков, зарезервированных для суперпользователя

        ulong s_free_blocks_count;//Счетчик числа свободных блоков	
 
        ulong s_free_inodes_count;//Счетчик числа свободных индексных дескрипторов	 

        ulong s_first_data_block;//Первый блок, который содержит данные. В зависимости от размера блока, это поле может быть равно 0 или 1	 

        ulong s_log_block_size;//Индикатор размера логического блока: 0 = 1 Кб; 1 = 2 Кб; 2 = 4 Кб	 

        ulong s_log_frag_size;//Индикатор размера фрагментов (кажется, понятие фрагмента в настоящее время не используется)
	 
        ulong s_blocks_per_group;//Число блоков в каждой группе блоков	 

        ulong s_frags_per_group;//Число фрагментов в каждой группе блоков	 

        ulong s_inodes_per_group;//Число индексных дескрипторов (inodes) в каждой группе блоков	 

        ulong s_mtime;//Время, когда в последний раз была смонтирована файловая система	 

        ulong s_wtime;//Время, когда в последний раз производилась запись в файловую систему s_mnt_count USHORT
        //Счетчик числа монтирований файловой системы. 
        //Если этот счетчик достигает значения, указанного в следующем поле (s_max_mnt_count), 
        //файловая система должна быть проверена (это делается при перезапуске), а счетчик обнуляется	
 
        short s_max_mnt_count;//Число, определяющее, сколько раз может быть смонтирована файловая система	 

        ushort s_magic	;//Магическое число'' (0xEF53), указывающее, что файловая система принадлежит к типу ex2fs	 

        ushort s_state	;//Флаги, указывающее текущее состояние файловой системы (является ли она чистой (clean) и т.п.)	
 
        ushort s_errors;	//Флаги, задающие процедуры обработки сообщений об ошибках (что делать, если найдены ошибки)	
 
        ushort s_pad;//Заполнение s_lastcheck ULONG Время последней проверки файловой системы	 

        ulong s_checkinterval;//Максимальный период времени между проверками файловой системы	 

        ulong s_creator_os;//Указание на тип ОС, в которой создана файловая система	 

        ulong s_rev_level;//Версия (revision level) файловой системы	 

        ulong s_reserved;//ULONG[235]	//Заполнение до 1024 байт

    }
}
