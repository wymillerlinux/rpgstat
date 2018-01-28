using System;
using System.Data;
using System.Threading;

namespace RPGStat
{
    public class Controller
    {
        private bool _isRunning;
        private bool _isProcessing;
        private Generator _generator; // has access to the generator class
        private Player _player; // has access to the player class
        private View _view; // has access to the view class

        public bool IsRunning
        {
            get { return _isRunning; }
            set { _isRunning = value; }
        }

        public bool IsProcessing
        {
            get => _isProcessing;
            set => _isProcessing = value;
        }

        
        public void InitStat()
        {
            _generator = new Generator();
            _player = new Player();
            _view = new View();

            Console.CursorVisible = false;
            TestText();
        }

        private void UpdateStatus()
        {
            
        }

        private void TestFunction()
        {
            Console.WriteLine("This is the Controller class.");
        }

        // test function for testing duh
        public void TestText()
        {
            TestFunction();
            _player.TestFunction();
            _generator.TestFunction();
            _view.TestFunction();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            Environment.Exit(0);
        }
        
        private void ManageGameLoop()
        {
            Console.WriteLine("Hello world");
        }
    }
}