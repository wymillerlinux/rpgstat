using System;
using System.Collections;
using System.Globalization;

namespace RPGStat
{
    public class View
    {
        #region Fields
        
        private Player _player;
        private Generator _generator;
        private Controller _controller;
        private string _userAnswer;
        
        #endregion
        
        #region Properties

        public string UserAnswer
        {
            get => _userAnswer; 
            set => _userAnswer = value;
        }
        
        #endregion
        
        #region Constructors

        public View()
        {
            
        }

        #endregion
        
        #region Methods

        public void TestFunction()
        {
            Console.WriteLine("This is the View class.");
        }

        public void DisplayMainMenu()
        {
            Console.WriteLine("        ### WELCOME ###");
            Console.WriteLine("## to Wyatt's RPG Stat Generator ##");
            Console.WriteLine();
            Console.WriteLine("   Please choose a option below");
            Console.WriteLine();
            Console.WriteLine("1. Generate");
            Console.WriteLine("2. Exit");
            Console.Write("ENTER A FIGURE:");

            _userAnswer = Console.ReadLine();
            _controller.MainMenuChooser(_userAnswer);
        }

        public void DisplayExitScreen()
        {
            Console.Clear();
            Console.WriteLine("Thanks for using Wyatt's RPG Stat Generator!\n");
        }

        #endregion
    }
}