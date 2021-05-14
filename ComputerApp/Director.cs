namespace ComputerApp
{
    public class Director
    {
        private IComputer _builder;

        public Director(IComputer builder)
        {
            Builder = builder;
        }

        public IComputer Builder
        {
            set => _builder = value;
        }


        public Computer BuildGamingComputer()
        {
            _builder.BuildOS("Windows");
            _builder.BuildStorage("SSD");
            _builder.BuildGraphicCard("NVidia");
            _builder.BuildCPU("AMD");
            _builder.BuildRAM("32");
            return _builder.GetComputer();
        }

        public Computer BuildDevComputer()
        {
            _builder.BuildOS("Linux");
            _builder.BuildStorage("HDD");
            _builder.BuildGraphicCard("Integrated Graphics");
            _builder.BuildCPU("Intel");
            _builder.BuildRAM("16");
            return _builder.GetComputer();
        }

        public Computer BuildCustomComputer(string OS, string Storage, string GraphicCard, string CPU, string RAM)
        {
            _builder.BuildOS(OS);
            _builder.BuildStorage(Storage);
            _builder.BuildGraphicCard(GraphicCard);
            _builder.BuildCPU(CPU);
            _builder.BuildRAM(RAM);
            return _builder.GetComputer();
        }
        
        
    }
}