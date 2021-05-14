using System.Text;

namespace ComputerApp
{
    public class Computer
    {
        private string _OS;
        private string _GraphicCard;
        private string _CPU;
        private string _RAM;
        private string _Storage;

        public void OS(string OS)
        {
            _OS = OS;
        }

        public void GraphicCard(string GraphicCard)
        {
            _GraphicCard = GraphicCard;
        }

        public void CPU(string CPU)
        {
            _CPU = CPU;
        }

        public void RAM(string RAM)
        {
            _RAM = RAM;
        }

        public void Storage(string Storage)
        {
            _Storage = Storage;
        }

        public override string ToString()
        {
            return $"Os: {_OS}, GraphicCard: {_GraphicCard}, Cpu: {_CPU}, Ram: {_RAM}, Storage: {_Storage}";
        }
    }
}