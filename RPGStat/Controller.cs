using System;
using System.Data;
using System.Threading;

namespace RPGStat
{
    public class Controller
    {
        private bool _isProcessing;
        private Generator _generator; // has access to the generator class
        private Player _player; // has access to the player class
        private View _view; // has access to the view class
        private Menu _menu; // has access to the menu class

        public bool IsRunning { get; set; }

        public bool IsProcessing
        {
            get => _isProcessing;
            set => _isProcessing = value;
        }

        public Controller()
        {
            
        }

        public void InitStat()
        {
            _generator = new Generator();
            _player = new Player();
            _view = new View();
            _menu = new Menu();

            IsRunning = true;
            IsProcessing = false;
            Console.CursorVisible = false;
            ManageGameLoop();
        }

        private void UpdateStatus()
        {

        }

        private void TestFunction()
        {
            Console.WriteLine("This is the Controller class.");
        }

        private void ManageGameLoop()
        {
            while (IsRunning)
            {
                _view.DisplayMainMenu();
                MainMenuChooser(_view.UserAnswer);

                if (IsRunning == false)
                {
                    _view.DisplayExitScreen();
                }
            }

        }

        public void MainMenuChooser(string userAnswer)
        {
            switch (userAnswer)
            {
                case "1":
                    _menu.MainMenu.Generate;
                    break;
                case "2":
                    _menu.MainMenu.Exit;
                    break;
                default:
                    Console.WriteLine("Please select valid figure. Press Enter to continue.");
                    Console.ReadLine();
                    _view.DisplayMainMenu();
                    break;
            }
        }
        
        
        
        
        
        
    }
}