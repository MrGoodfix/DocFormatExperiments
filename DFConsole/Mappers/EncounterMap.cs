using DFConsole.Configuration;
using DFConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFConsole.Mappers
{
    public class EncounterMap : OpenXmlMap<Encounter>
    {
        public EncounterMap()
        {
            Map(m => m.Id, "Medicaid Id");
            Map(m => m.Name, "Name");
            Map(m => m.Date, "Service Date");
        }
    }
}
