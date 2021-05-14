namespace ComputerApp
{
    public class Development : IComputer
    {
        private Computer _comp;
        public Development()
        {
            _comp = new Computer();
        }
        public void BuildOS()
        {
           _comp.OS("Linux");
        }

        public void BuildGraphicCard()
        {
            _comp.GraphicCard("Intel");
        }

        public void BuildCPU()
        {
            _comp.CPU("Intel");
        }

        public void BuildRAM()
        {
            _comp.RAM("16");
        }

        public void BuildStorage()
        {
            _comp.Storage("HDD");
        }

        public Computer GetComputer()
        {
            return _comp;
        }
    }
}