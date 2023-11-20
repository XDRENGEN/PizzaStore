using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Ordre
    {

        //Leveringsgebyret er et fast beløb på 40kr.
        private const double _levering = 40.0;


        //Instancefelter

        private Pizza _pizza;
        private Kunde _kunde;


        //default til false
        public bool ØnskerLevering { get; set; } = false; 



        //Properties

        public Pizza pizza
        {
            get { return _pizza; }
            set { _pizza = value; }
        }

        public Kunde Kunde
        {
            get { return _kunde; }
            set { _kunde = value; }
        }



        //Constructor

        public Ordre()
        {
            _pizza = null;
            _kunde = null;
        }

        public Ordre(Pizza pizza, Kunde kunde)
        {
            _pizza = pizza;
            _kunde = kunde;
        }



        //Metoder

        public void TilføjLevering()
        {
            ØnskerLevering = true;
        }


        //Prisen * med 1.25 som er moms.
        public double CalculateTotalPrice()
        {

            double prisMedMoms = pizza.Pris * 1.25;
            if (ØnskerLevering)
            {
                prisMedMoms += _levering;

            }
            return prisMedMoms;
        }



        //Tostring

        public override string ToString()
        {
            return $"{{{nameof(pizza)}={pizza}, {nameof(Kunde)}={Kunde}}}";
        }


    }


}
