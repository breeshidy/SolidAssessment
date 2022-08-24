using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Animal
    {
        public virtual string GetName() => nameof(Animal);

        public virtual string GetHabitat() => "Habitat";
    }
}
