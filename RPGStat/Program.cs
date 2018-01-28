using System;

namespace RPGStat
{
    class Program
    {
        // has access to controller
        
        public static void Main(string[] args)
        {
            Controller _controller = new Controller();
            _controller.InitStat();
        }
    }
}