using System.Collections.Generic;
using System.Text;

namespace ComputerApp
{
    public class Computer
    {
        public List<object> components = new();

        public void Add(string component)
        {
            components.Add(component);
        }

        public string ListComponents()
        {
            var builder = new StringBuilder();
            foreach (string component in components) builder.Append(component + ", ");

            return builder.ToString(0, builder.Length - 2);
        }
    }
}