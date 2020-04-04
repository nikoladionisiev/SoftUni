using _07._Military_Elite.Contracts;
using _07._Military_Elite.Enumerations;
using _07._Military_Elite.Exceptions;
using System;


namespace _07._Military_Elite.Models
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary)
        {
            this.Corps = this.TryParseCorps(corps);
        }

        public Corps Corps { get; private set; }

        Corps ISpecialisedSoldier.Corps => throw new NotImplementedException();

        private Corps TryParseCorps(string corpsStr)
        {
            bool parsed = Enum.TryParse<Corps>(corpsStr, out Corps corps);

            if (!parsed)
            {
                throw new InvalidCorpsException();
            }
            return corps;
        }
    }
}
