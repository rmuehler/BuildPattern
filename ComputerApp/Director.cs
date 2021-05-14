namespace ComputerApp
{
    public class Director
    {
        private IComputer _builder;

        public Director(IComputer computer)
        {
            _builder = computer;
        }

        public Computer BuildGamingPc()
        {
            _builder.BuildOS();
            _builder.BuildStorage();
            _builder.BuildGraphicCard();
            _builder.BuildCPU();
            _builder.BuildRAM();
            return _builder.GetComputer();
        }
    }
}