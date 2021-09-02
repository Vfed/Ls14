using System;

namespace Ls14
{
    public class Firm : IFirm
    {
        public string FirmName { get; set; }
        public IFirmUnit[] FirmUnits { get; set; }
        public Firm(string name, FirmUnit[] units)
        {
            FirmName = name;
            FirmUnits = units;
        }
    }
    public class FirmUnit : IFirmUnit
    {
        public string UnitName { get; set; }
        public IGroup UnitTeam { get; set; }
        public ITask Tasks { get; set; }
        public FirmUnit(string name, Group group, Task task)
        {
            UnitName = name;
            UnitTeam = group;
            Tasks = task;
        }
    }
    public class Person : IPerson
    {
        public string Name { get; set; }
        public Person(string name)
        {
            this.Name = name;
        }
    }
    public class Group : IGroup
    {
        public IPerson[] People { get; set; }
        public Group(Person[] peoples)
        {
            People = new Person[peoples.Length];
            for (int i = 0; i < peoples.Length; i++)
            {
                People[i] = new Person(peoples[i].Name);
            }
        }
    }
    public class Task : ITask
    {
        public string TaskTheam { get; set; }
        public Task(string task)
        {
            TaskTheam = task;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
