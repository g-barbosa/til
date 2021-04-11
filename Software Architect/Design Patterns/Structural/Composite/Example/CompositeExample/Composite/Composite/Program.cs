using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev1 = new Developer("dev 1", "000.000.000-00");
            Developer dev2 = new Developer("dev 2", "111.111.111-11");
            Developer dev3 = new Developer("dev 3", "222.222.222-22");
            Developer dev4 = new Developer("dev 4", "333.333.333-33");

            TechLead tech1 = new TechLead("tech 1", "444.444.444-44");

            tech1.AddDeveloper(dev1);
            tech1.AddDeveloper(dev2);

            TechLead tech2 = new TechLead("tech 2", "555.555.555-55");

            tech2.AddDeveloper(dev3);
            tech2.AddDeveloper(dev4);

            Manager manager = new Manager("manager", "666.666.666-66");

            manager.AddTechLead(tech1);
            manager.AddTechLead(tech2);

            ShowThree showThree = new ShowThree(manager);
            showThree.GetThree();
        }
    }
}
