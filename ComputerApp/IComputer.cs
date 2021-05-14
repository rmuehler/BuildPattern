namespace ComputerApp
{
    public interface IComputer
    {
        void BuildOS();
        void BuildGraphicCard();
        void BuildCPU();
        void BuildRAM();
        void BuildStorage();
        Computer GetComputer();
    }
}