using System;

namespace ConsoleApp18
{
    class time
    {
        private int houre;
        private int minute;
        public int Houre
        {
            get { return houre; }
            set { houre = value; }
        }
        public int Minute
        {
            get { return minute; }
            set { minute = value; }
        }
        public time() { }
        public time(int hore, int minute)
        {
            houre = Houre;
            minute = Minute;
        }
        public void calc()
        {
            if (24 <= houre && minute <= 59)
            {

                if (houre <= 12)
                {
                    Console.WriteLine(houre + ":" + minute + "AM");

                }

                else if (houre > 12)
                {
                    houre = houre - 12;
                    Console.WriteLine(houre + ":" + minute + "PM");
                }
                else
                {
                    Console.WriteLine("not correct");
                }

            }
        }//end class time
        class main
        {
            public static void Main()
            {
                time t = new time();
                t.Houre = Convert.ToInt32(Console.ReadLine());
                t.Minute = Convert.ToInt32(Console.ReadLine());
                t.calc();
            }
        }
    }
}
