using System;

namespace ComputerApp
{
    public class Gaming : IComputer
    {
        private Computer _computer;

        public Gaming()
        {
            _computer = new Computer();
        }
        
        public void BuildOS()
        {
            _computer.OS("Windows");
        }

        public void BuildGraphicCard()
        {
            _computer.GraphicCard("AMD");
        }

        public void BuildCPU()
        {
           _computer.CPU("AMD");
        }

        public void BuildRAM()
        {
            _computer.RAM("32");
        }

        public void BuildStorage()
        {
            _computer.Storage("SSD");
        }

        public Computer GetComputer()
        {
            return _computer;
        }
    }
}