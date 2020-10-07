using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace BMI_Calc
{
    [Serializable]
    public class Person
    {
        public string Name;
        public string Gender;
        public string BMI;

        public Person()
        {

        }
        public Person(string name, string gender, string bmi)
        {
            Name = name;
            BMI = bmi;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"Name: {Name} BMI: {BMI}";
        }

    }
}
