using System;

namespace RPGStat
{
    class Program
    {
        public static void Main(string[] args)
        {
            // brings up the controller
            Controller controller = new Controller();
            controller.InitStat();
        }
    }
}