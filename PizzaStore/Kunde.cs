using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Kunde
    {
        //Instancefelter

        private string _navn;
        private string _tlf;



        //Properties

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Tlf
        {
            get { return _tlf; }
            set { _tlf = value; }

        }



        //Constructor

        public Kunde(string navn, string tlf)
        {
            Navn = navn;
            _tlf = tlf;
        }



        //Tostring

        public override string ToString()
        {
            return $"{{{nameof(Navn)}={Navn}, {nameof(Tlf)}={Tlf}}}";
        }

    }
}
