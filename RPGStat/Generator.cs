using System;

namespace RPGStat
{
    public class Generator
    {
        #region Fields
        
        // characters to generate from
        private enum Character
        {
            Human,
            WoodElf,
            Dwarf,
            DarkKnight,
            Unicorn
        }
        
        // have access to conntroller and number determines which race to generate
        private Controller _controller;
        private Player _player;

        #endregion
        
        #region Properties
        
        #endregion

        #region Constructors
        
        public Generator()
        {
            
        }

        public Generator(Player player, Controller controller)
        {
            _controller = controller;
            _player = player;
        }

        #endregion

        #region Methods

        public void TestFunction()
        {
            Console.WriteLine("This is the Generator class.");
        }

        public int GenerateStrength()
        {
            // code goes here
            return 0;
        }

        public int GenerateCharisma()
        {
            // code goes here
            return 0;
        }

        static public int GenerateIntelligence()
        {
            int generation = 0;
            // code goes here
            return generation;
        }

        #endregion

    }
}