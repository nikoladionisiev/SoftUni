using _07._Military_Elite.Contracts;
using _07._Military_Elite.Enumerations;
using _07._Military_Elite.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite.Models
{
    public class Mission : IMission
    {
        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = this.TryParseState(state);
        }

        public string CodeName { get; private set; }

        public State State { get; private set; }

        public void CompleateMission()
        {
            if (this.State == State.Finished)
            {
                throw new InvalidMissionStateException();
            }
            this.State = State.Finished;
        }

        private State TryParseState(string stateStr)
        {
            State state;
            bool parsed = Enum.TryParse<State>(stateStr, out state);

            if (!parsed)
            {
                throw new InvalidMissionStateException();
            }
            return state;
        }
    }
}
