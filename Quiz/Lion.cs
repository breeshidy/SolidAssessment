﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{

    public class Lion : IAnimal
    {
        public string GetName() => nameof(Lion);

        public string GetHabitat() => "Wild";
    }
}