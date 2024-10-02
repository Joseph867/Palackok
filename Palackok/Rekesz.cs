using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palackok
{
    internal class Rekesz
    {
        private int max_teherbiras;
        private List<Palack> palackok;

        public Rekesz(int max_teherbiras)
        {
            this.max_teherbiras = max_teherbiras;
            this.palackok = new List<Palack>();
        }

        public int MaxTeherbiras { get => max_teherbiras; set => max_teherbiras = value; }
        public List<Palack> Palackok { get => palackok; set => palackok = value; }

        public double Suly()
        {
            if (palackok.Count == 0)
            {
                return 0;
            }

            return palackok.Sum(p => p.Suly());
        }

        public void UjPalack(Palack palack)
        {
            if (Suly() + palack.Suly() <= max_teherbiras)
            {
                palackok.Add(palack);
            }
        }

        public int OsszesPenz()
        {
            int osszesPenz = 0;

            foreach (var palack in palackok)
            {
                if (palack is VisszavalthatoPalack visszavalthatoPalack)
                {
                    osszesPenz += visszavalthatoPalack.Palackdij;
                }
            }

            return osszesPenz;
        }
    }
}
