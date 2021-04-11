using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Developer : Employee
    {
        private string _name;
        private string _CPF;
        public Developer(string name, string CPF)
        {
            _name = name;
            _CPF = CPF;
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
    }
}
