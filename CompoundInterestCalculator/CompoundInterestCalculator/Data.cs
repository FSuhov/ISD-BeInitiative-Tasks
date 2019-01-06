using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundInterestCalculator
{
    public static class Data
    {
        public static readonly string USER_MANUAL = string.Format(
            "COMPOUND INTEREST CALCULATOR{0}"
            + "=========================================================={0}"
            + "This application calculated compound interest or result of that interest{0}"
            + "=========================================================={0}",
            Environment.NewLine);

        public const string DELIMITER = "===================================================";
    }
}
