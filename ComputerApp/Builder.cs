using System;

namespace ComputerApp
{
    public class Builder : IComputer
    {
        private Computer _computer = new Computer();

        public Builder()
        {
            Reset();
        }
        
        public void BuildOS(string OS)
        {
            _computer.Add(OS);
        }

        public void BuildGraphicCard(string GraphicCard)
        {
            _computer.Add(GraphicCard);
        }

        public void BuildCPU(string CPU)
        {
           _computer.Add(CPU);
        }

        public void BuildRAM(string RAM)
        {
            _computer.Add(RAM);
        }

        public void BuildStorage(string Storage)
        {
            _computer.Add(Storage);
        }

        public Computer GetComputer()
        {
            return _computer;
        }

        public void Reset()
        {
            _computer = new Computer();
        }
    }
}