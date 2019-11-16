using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbyPierwsze.Main
{
    public class PrimaryNumbers {
        private List<int> numbers;

        public List<int> Numbers {
            get { return numbers; }
        }

        public bool IsPrimary(int number) {
            if (number < 2) return false;
            for (int i = 2; i*i <= number; i++) {
                if (number % i == 0) return false;
            }
            return true;
        }

        public List<int> GetAllToLimit(int limit) {
            var primaryNumbers = new List<int>();
            for (int i = 2; i <= limit; i++) {
                if(IsPrimary(i)) primaryNumbers.Add(i);
            }

            this.numbers = primaryNumbers;
            return primaryNumbers;
        }

        public int CountPrimaryNumbers(int d, int g) {
            var primaryNumbers = new List<int>();
            if (d < 2 || d > g) return 0;
            for (int i = d; i <= g; i++)
            {
                if (IsPrimary(i)) primaryNumbers.Add(i);
            }

            return primaryNumbers.Count;
        }
        public List<int> ShowPrimaryNumbers(int d, int g)
        {
            var primaryNumbers = new List<int>();
            if (d < 2 || d > g) return primaryNumbers;
            for (int i = d; i <= g; i++)
            {
                if (IsPrimary(i)) primaryNumbers.Add(i);
            }

            return primaryNumbers;
        }
    }
}
