using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class KundeListe
    {
        //Instancefelter

        private List<Kunde> _liste;



        //Properties

        public List<Kunde> Liste
        {
            get { return _liste; }
            set { _liste = value; }
        }



        //Konstruktør

        public KundeListe()
        {
            _liste = new List<Kunde>();
        }



        //Metoder (Tilføj kunde/kunder)

        public void Add(Kunde kunde)
        {
            _liste.Add(kunde);
        }

        public List<Kunde> GetKundeListe()
        {
            return _liste;
        }

    }
}
