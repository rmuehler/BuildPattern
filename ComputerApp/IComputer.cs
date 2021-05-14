namespace ComputerApp
{
    public interface IComputer
    {
        void BuildOS(string OS);
        void BuildGraphicCard(string GraphicCard);
        void BuildCPU(string CPU);
        void BuildRAM(string RAM);
        void BuildStorage(string Storage);
        Computer GetComputer();
    }
}