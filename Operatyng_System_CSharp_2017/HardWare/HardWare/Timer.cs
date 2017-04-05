using System;
using System.Timers;
//using System.Threading;

namespace HardWare
{
    class My_Timer
    {
        private Timer timer { set; get; }//Конструктор Timer
        //Инициализирует новый экземпляр класса Timer.

        public My_Timer(double Interval = 1000.0)
        {
            timer.AutoReset = true;
            //Возвращает или задает логическое значение,
            //определяющее, должен ли объект Timer вызывать событие Elapsed один раз (false) или неоднократно (true).

            timer.Enabled = true;
            //Возвращает или задает значение, определяющее, должен ли объект Timer вызывать событие Elapsed.

            timer.Interval = Interval;
            
        }

        public void Add_Func_For_Elapsing(ElapsedEventHandler del)
        {
            timer.Elapsed += del;
        }

        
       
        ~My_Timer()
        {
            timer.Stop();
            timer.Dispose();
        }
      
    }
}


