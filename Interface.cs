using System;
using System.Collections.Generic;
using System.Text;

namespace Ls14
{
    public interface IFirm
    {
        public string FirmName { get; set; }
        public IFirmUnit[] FirmUnits { get; set; }
    }
    public interface IFirmUnit
    {
        public string UnitName { get; set; }
        public IGroup UnitTeam { get; set; }
        public ITask Tasks { get; set; }
    }
    public interface IPerson
    {
        public string Name { get; set; }
    }
    public interface IGroup
    {
        public IPerson[] People { get; set; }
    }
    public interface ITask
    {
        public string TaskTheam { get; set; }
    }
}
