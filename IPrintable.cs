using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp1
{
    // Interface IPrintable
    interface IPrintable
    {
        void Print();
    }

    // Interface ISerializable
    interface ISerializable
    {
        void SaveToFile(string filename);
    }

    // Implementing both interfaces in Report class
    class Report : IPrintable, ISerializable
    {
        private string content;

        public Report(string content)
        {
            this.content = content;
        }

        public void Print()
        {
            Console.WriteLine("Report Content: " + content);
        }

        public void SaveToFile(string filename)
        {
            File.WriteAllText(filename, content);
            Console.WriteLine("Report saved to " + filename);
        }
    }
}