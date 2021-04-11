using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class TechLead : Employee
    {
        private string _name;
        private string _CPF;
        private List<Developer> _developers;
        public TechLead(string name, string CPF)
        {
            _name = name;
            _CPF = CPF;
            _developers = new List<Developer>();
        }

        public override string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public override string CPF
        {
            get { return _CPF; }
            set { _CPF = value; }
        }

        public void developers()
        {
            foreach (var dev in _developers)
                Console.WriteLine(new string('-', 6) + dev.Name);
        } 

        public void AddDeveloper(Developer dev)
        {
            _developers.Add(dev);
        }
    }
}
