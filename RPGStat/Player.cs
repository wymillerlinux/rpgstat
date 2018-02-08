using System;
using System.Collections.Generic;

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

        public Player()
        {
            
        }

        #endregion

        #region Methods

        public void TestFunction()
        {
            Console.WriteLine("This is the Player class.");
        }

        public int NumberToBeGenerated()
        {
            Random random = new Random();
            int numGenerated = random.Next(1, 3);

            return numGenerated;
        }

        #endregion
    }
}