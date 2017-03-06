using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Classes
{

    public interface IVehichle
    {
        int Distance { get; }
        double Toll { get; }

        string TypeOfVehichle { get; }

        double CalculateToll(int distance);

    }
}
