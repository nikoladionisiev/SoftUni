using _07._Military_Elite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private ICollection<IPrivate> privates;

        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
        {
            this.privates = new List<IPrivate>();
        }

        public IReadOnlyCollection<IPrivate> Privates => (IReadOnlyCollection<IPrivate>)this.privates;

        public void AddPrivate(IPrivate @private)
        {
            this.privates.Add(@private);
        }
    }
}
