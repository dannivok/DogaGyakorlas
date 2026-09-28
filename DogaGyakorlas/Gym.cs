using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogaGyakorlas
{
    internal class Gym
    {
        private string _name;
        private List<Membership> _memberships;

        public string Name { get { return _name; } set { _name = value; } }
        public List<Membership> Memberships { get { return _memberships; } }


        public Gym(string Name)
        {
            _name = Name;
            _memberships = new List<Membership>();
        }

        public void AddMembership(Membership membership)
        {
            _memberships.Add(membership);
        }

        public int TotalIncome()
        {
            int total = 0;
            foreach (Membership item in _memberships)
            {
                total += item.TotalCost();
            }
            return total;
        }

        public Member MostActive()

        {
            Member aktiv = _memberships[0].Owner;
            foreach (Membership item in _memberships)
            {
                if (item.Owner.Visits <= aktiv.Visits)
                {
                    aktiv=item.Owner;
                }
            }
            return aktiv;
        }

        public Membership BestValue()
        {
            Membership best = _memberships[0];
            foreach (Membership item in _memberships)
            {
                if (item.PricePerVisit() < best.PricePerVisit()) 
                {
                    best=item;
                }
            }
            return best;
        }
    }
}

