using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Manager : Employee
    {
        private string _name;
        private string _CPF;
        private List<TechLead> _techLeads;
        public Manager(string name, string CPF)
        {
            _name = name;
            _CPF = CPF;
            _techLeads = new List<TechLead>();
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

        public void techLeads()
        {
            foreach (var techlead in _techLeads)
            {
                Console.WriteLine(new string('-', 4) + techlead.Name);
                techlead.developers();
            }

        }

        public void AddTechLead(TechLead techLead)
        {
            _techLeads.Add(techLead);
        }
    }
}
