using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ant_algorithm.Classes
{
    /**
     * Класс улья
     *
     * Содержит популяцию муравьев, карту, запускает процессы:
     *    прохода муравьев
     *    обновления следов феромонов
     */
    class c__hive
    {

        private List<c__ant> l__ant; // Список муравьев в улье
        
        private byte   b__ant_count; // Количество муравьев в улье
        private Random rnd_random;   // Генератор случайных чисел


        public static byte   b__end_node;  // Конец пути
        public static c__map map__map;     // Карта


        /**
         * Конструктор 
         * 
         * @param  List<byte[]>  l__ba__conn_in  Список связей узлов (для карты)
         * @param  byte          b__end_point    Индекс узла до которого ищем путь 
         */
        public c__hive(List<byte[]> l__ba__conn_in, byte b__end_point)
        {
            rnd_random = new Random(); // Установить генератор случайных чисел

            l__ant = new List<c__ant>(); //Установить список муравьев


            //
            // Если количество муравьев не было установлено вручную, то
            // задать стандартное значение
            //
            if (b__ant_count <= 0)
            {
                b__ant_count = 10; // Задать стандартное значение
            }


            //
            // Заполнить улей муравьями
            //
            for (int i__1 = 0; i__1 < b__ant_count; i__1++)
            {
                l__ant.Add(new c__ant(rnd_random)); // Добавить муравья
            }


            map__map = new c__map(l__ba__conn_in); // Установить карту

            b__end_node = b__end_point; // Установить индекс узла до которого ищется путь
        }



        /**
         * Сделать итерацию
         */
        public void iteration()
        {
            //
            // Выполнить поиск пути всеми муравьями
            //
            foreach (c__ant ant_item in l__ant)
            {
                ant_item.passage(); // Выполнить проход
            }

            map__map.update_pheromons(); // Обновить значение феромонов 
        }



        /**
         * Получить длину найденного пути 
         * 
         * @return  byte  Длина найденного пути
         */
        public byte get_way_length()
        {
            byte b__path_length;
            byte b__current_node;

            List<c__edge> l__ed__way;

            c__edge ed__item;


            b__path_length = 0;

            b__current_node = 1;


            do
            {
                l__ed__way = map__map.l__ed__edges.Where(o => o.b__from == b__current_node).ToList();

                ed__item = l__ed__way.OrderByDescending(o => o.d__phero).First();


                b__path_length += ed__item.b__length;

                b__current_node = ed__item.b__to;
            }
            while (b__current_node != b__end_node);


            return b__path_length;
        }




        /**
         * Установить количество муравьев в улье
         * 
         * @param  byte  b__count  Количество муравьев
         */
        public void set_ant_count(byte b__count)
        {
            b__ant_count = b__count; // Установить значение
        }
    }




    /**
     * Класс муравья
     */
    class c__ant
    {

        private List<byte>    l__b__tabu_list; // Список индексов пройденных узлов
        private List<c__edge> l__ed__passed;   // Список пройденых ребер

        private byte   b__current_node; // Текущий узел
        private Random rnd__random;     // Генератор случайных чисел

        private double d__a; // Индекс для нужный для вычислений при переходе к ребру
        private double d__b; // Индекс для нужный для вычислений при переходе к ребру 
        private double d__k; // Параметр регулирующий оставляемые на ребрах феромоны



        /** 
         * Конструктор  
         * 
         * @param  Random  rnd__in  Генератор случайных чисел
         */
        public c__ant(Random rnd__in)
        {
            rnd__random     = rnd__in; // Установить генератор случайных чисел 
            b__current_node = 1;       // Установить текущий узел (начальная позиция)


            //
            // Установить индексы для вычислений при переходе
            //
            d__a = 2;
            d__b = 1;
            d__k = 1;


            l__b__tabu_list = new List<byte>(); // Установить список табу

            l__ed__passed = new List<c__edge>(); // Установить список пройденных ребер
        }



        /**
         * Выполнить проход
         */
        public void passage()
        {
            //
            // Выполнять ходы, пока возможно
            //
            do
            {

            }
            while (make_a_move());


            passage_is_over(); // Проход закончен
        }



        /**
         * Сделать ход
         * 
         * @return  bool  Можно ли продолжить путь
         */
        public bool make_a_move()
        {
            List<c__edge> l__edges; // Ребра по которым можно совершить переход


            l__edges = c__hive.map__map.get_edges_from_node(b__current_node); // Получить все доступные ребра 


            //
            // Оставить ребра которые приведут в новый узел
            //
            foreach (byte b__item in l__b__tabu_list)
            {
                l__edges = l__edges.Where(o => o.b__to != b__item).ToList();
            }


            //
            // Если некуда идти, то выйти
            //
            if (l__edges.Count == 0)
            {
                return false; // Ходов нет
            }


            l__b__tabu_list.Add(b__current_node); // Добавить в табу лист узел из которого уходим


            b__current_node = calculate_move(l__edges); // Совершить переход к следующему узлу


            //
            // Если достигнут искомый узел, то выйти
            //
            if (b__current_node == c__hive.b__end_node)
            {
                return false; // Найден искомый узел
            }


            return true; // Движение можно продолжать
        }



        /**
         * Выбрать ребро по которому пройти
         * 
         * @param  List<c__edge>  l__edges  Ребра, дострупные для прохода
         * 
         * @return  byte  Ребро к которому совершен переход
         */
        private byte calculate_move(List<c__edge> l__edges)
        {
            double       d__values_sum;    // Сумма всех значений узлов
            double       d__rand_selector; // Селектор для выбора ребра (случайное от 0 до 1)
            double       d__calc_sum;      // Нужна для определения ребра по которому совершится проход 
            c__edge      ed__to_move;      // Ребро по которому будет совершен переход
            List<double> l__d__values;     // Сисок значений для ребер


            l__d__values = new List<double>(); // Установить список значений ребер

            d__calc_sum = 0; // Установить переменную          

            d__values_sum = 0; // Установить сумму всех значений ребер

            d__rand_selector = rnd__random.NextDouble(); // Установить селектор

            ed__to_move = null; // Установить ребро для прехода             


            //
            // Рассчитать сумму всех значений узлов
            //
            foreach (c__edge ed__item in l__edges)
            {
                d__values_sum += Math.Pow(ed__item.d__phero, d__a) + 
                                (1 / Math.Pow(ed__item.b__length, d__b));
            }


            //
            // Рассчитать значения для ребер
            //
            foreach (c__edge ed__item in l__edges)
            {
                //
                // Рассчиать значение ребра и добавить его в список
                //
                l__d__values.Add(
                                    (Math.Pow(ed__item.d__phero, d__a) +
                                     (1 / Math.Pow(ed__item.b__length, d__b))
                                    ) / d__values_sum
                                    
                                ); 
            }


            //
            // Выбрать ребро по которому совершится переход
            //
            for (int i__1 = 0; i__1 < l__edges.Count; i__1++)
            {
                d__calc_sum += l__d__values[i__1];


                //
                // Проверить выбрано ли ребро
                //
                if (d__calc_sum >= d__rand_selector)
                {
                    ed__to_move = l__edges[i__1]; // Установить ребро по которому совершится переход

                    break; // Выйти из цикла
                }    
                 
            }


            // 
            // Добавить в список пройденное ребро
            //
            l__ed__passed.Add(ed__to_move);


            return ed__to_move.b__to; // Вернуть узел к которому совершен переход
        }



        /**
         * Приготовить муравья к новой итерации
         * (очистить список пройденных узлов)
         * Вызывается когда муравей прошел путь до конца
         */
        public void passage_is_over()
        {
            double d__pheromon_boost; // Значение на которое увеличится феромон
            double d__path_length;    // Длина пройденного пути 
            

            d__pheromon_boost = 0; // Установить начальное значение уселителя 
            d__path_length    = 0; // Установить начальное значение длины пути 


            //
            // Вычислить длину пройденного пути
            //
            foreach (c__edge ed__item in l__ed__passed)
            {
                d__path_length += ed__item.b__length; // Добавить длину ребра
            }


            //
            // Рассчитать уселитель
            //
            d__pheromon_boost = d__k / d__path_length;


            //
            // Увеличить значение феромона на пройденном пути 
            //

            foreach (c__edge ed__item in l__ed__passed)
            {
                ed__item.d__phero += d__pheromon_boost; // Усилить значение феромона на пройденном пути 
            }


            l__b__tabu_list.Clear(); // Очистить список пройденных узлов

            l__ed__passed.Clear();   // Очистить список пройденных ребер


            b__current_node = 1; // Поставить муравья на начальную позицию
        }
    }




    /**
     * Класс карты
     * Такеже содержит феромоны.
     */
    class c__map
    {

        public List<c__edge> l__ed__edges; // Список ребер



        /**
         * Конструктор
         * 
         * @param  List<byte[]>  l__ba__conn_in  Список связей узлов
         */
        public c__map(List<byte[]> l__ba__conn_in)
        {
            l__ed__edges = new List<c__edge>(); // Установить список ребер


            //
            // Добавить ребра на карту
            //
            foreach (byte[] ba__item in l__ba__conn_in)
            {
                l__ed__edges.Add(new c__edge(ba__item[0], ba__item[1], ba__item[2]));
            }
        }



        /**
         * Вернуть все ребра для узла
         * 
         * @param  byte  b__from_node  Индекс узла 
         * 
         * @return List<c__edge>  Список доступных ребер
         */
        public List<c__edge> get_edges_from_node(byte b__from_node)
        {
            return l__ed__edges.Where(o => o.b__from == b__from_node).ToList();
        }



        /**
         * Обновить значения феромонов
         * Вызывается в конце каждой итерации улья
         */
        public void update_pheromons()
        {
            //
            // Перебрать все ребра и обновить на них
            // значение феромона
            //
            foreach (c__edge ed__item in l__ed__edges)
            {
                ed__item.d__phero = ed__item.d__phero * 0.8; // Уменьшить значение феромона 
            }
        }
    }
}
