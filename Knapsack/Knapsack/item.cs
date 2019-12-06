using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack
{
    class item
    {
        private string name;
        private int worth;
        private int weight;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Worth
        {
            get
            {
                return worth;
            }

            set
            {
                worth = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }
    }
}
