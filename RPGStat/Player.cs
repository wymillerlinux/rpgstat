using System;

namespace RPGStat
{
    public class Player
    {
        #region Fields
        
        private Controller _controller;
        private Generator _generator;
        private string _name;
        private int _numberGeneration;
        
        #endregion
        
        #region Properties
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }

        public int NumberGeneration
        {
            get => _numberGeneration;
            set => _numberGeneration = value;
        }
        
        #endregion
        
        #region Constructors
        
        #endregion

        #region Methods

        public void TestFunction()
        {
            Console.WriteLine("This is the Player class.");
        }

        #endregion
    }
}