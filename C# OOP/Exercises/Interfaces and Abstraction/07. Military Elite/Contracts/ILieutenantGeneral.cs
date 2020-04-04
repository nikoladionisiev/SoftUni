using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite.Contracts
{
    interface ILieutenantGeneral : IPrivate
    {
        IReadOnlyCollection<IPrivate> Privates { get; }

        void AddPrivate(IPrivate @private);
    }
}
