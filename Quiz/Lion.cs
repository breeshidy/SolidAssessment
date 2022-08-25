using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{

    public class Lion : Animal
    {
        public override string GetName() => nameof(Lion);

        public override string GetHabitat() => "Wild";
    }
}
