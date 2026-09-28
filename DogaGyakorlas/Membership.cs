using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogaGyakorlas
{
    internal class Membership
    {
        private Member _owner;
        private int _monthlyprice;
        private int _months;

        public Member Owner { get { return _owner; } set { _owner = value; } }
        public int MonthlyPrice
        {
            get { return _monthlyprice; }
            set { _monthlyprice = value; }
        }

        public int YearlyPrice { get { return _months; } set { _months = value; } }

        public Membership(Member owner, int monthlyprice,int months)
        {
            _owner = owner;
            _monthlyprice = monthlyprice;
            _months = months;
        }

        public int TotalCost()
        {
            int osszeg = _monthlyprice * _months;

            if (_owner.IsStudent)
            {
                osszeg = osszeg * 80 / 100;
            }

            return osszeg;
        }

        public void Extend(int months2)
        {
            _months += months2;
        }

        public int PricePerVisit()
        {
            int total = TotalCost();

            if (_owner.Visits == 0)
            {
                return total;
            }

            return total / _owner.Visits;
        }



    }
}
