using _07._Military_Elite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        ICollection<IRepair> repairs;

        public Engineer(int id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
            this.repairs = new List<IRepair>();
        }

        public IReadOnlyCollection<IRepair> Repairs => (IReadOnlyCollection<IRepair>)this.repairs;

        public void AddRepair(IRepair repair)
        {
            this.repairs.Add(repair);
        }
    }
}
