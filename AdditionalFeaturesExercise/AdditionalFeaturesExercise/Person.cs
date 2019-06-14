using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesExercise
{
    class Person
    {

        public Person(string name) : this(name, 100) //Chain two constructors together. 
        {

        }
        public Person(string name, double weightKG)
        {
            Name = name;
            WeightKG = weightKG;
        }

        public string Name { get; set; }
        public double WeightKG { get; set; }
    }

}
