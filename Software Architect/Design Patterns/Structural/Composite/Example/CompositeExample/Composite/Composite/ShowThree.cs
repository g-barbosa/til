using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class ShowThree
    {
        private readonly Manager _manager;
        public ShowThree(Manager manager)
        {
            _manager = manager;
        }

        public void GetThree()
        {
            Console.WriteLine(new string('-', 2) + _manager.Name);

            _manager.techLeads();
        }
    }
}
