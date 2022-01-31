using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Task
{
    class Cars
    {
        public string seher;
        public string marka;
        public string model;
        public string buraxilisIli;
        public string reng;
        public string yanacaqNovu;
        public string muherrikGucu;
        public string yurus;
        public string qiymet;

        public string GetInfo() 
        
        {

            string output = ($"{this.seher}\n{this.marka}\n{this.model}\n" +
                    $"{this.buraxilisIli}\n{this.reng}\n{this.yanacaqNovu}\n" +
                    $"{this.reng}\n{this.muherrikGucu}\n{this.yurus}\n{this.qiymet}");

            return output;
        }
       

    }
}
