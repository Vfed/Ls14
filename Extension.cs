using System;
using System.Collections.Generic;
using System.Text;

namespace Ls14
{
    public static class Extension
    {
        public static void GetPersonal(this Firm firm) 
        {
            foreach (var unit in firm.FirmUnits)
            {
                foreach (var person in unit.UnitTeam.People) 
                {
                    Console.WriteLine($"{person.Name}");  
                }
            }
        }
    }
}
