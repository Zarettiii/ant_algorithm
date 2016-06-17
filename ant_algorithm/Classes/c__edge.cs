using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ant_algorithm.Classes
{
    /**
     * Класс ребра
     */ 
    class c__edge
    {
        public byte   b__from;   // Индекс "откуда"
        public byte   b__to;     // Индекс "куда"
        public byte   b__length; // Длина ребра
        public double d__phero;  // Значение феромона на ребре



        /**
         * Конструктор
         * 
         * @param  byte  b__from__in   Откуда
         * @param  byte  b__to__in     Куда 
         * @param  byte  b__length_in  Длина ребра
         */
        public c__edge(byte b__from__in, byte b__to__in, byte b__length_in)
        {
            //
            // Установить значения полей
            //
            b__from   = b__from__in;
            b__to     = b__to__in;
            b__length = b__length_in;
            d__phero  = 0;
        }
    }
}
