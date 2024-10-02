using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palackok
{
    internal class Palack
    {
        private string ital;
        private int maxUrtartalom;
        private int jelenlegiUrtartalom;

        public Palack(string ital, int maxUrtartalom, int jelenlegiUrtartalom = 1)
        {
            this.Ital = ital;
            this.MaxUrtartalom = maxUrtartalom;
            this.JelenlegiUrtartalom = jelenlegiUrtartalom;
        }

        public string Ital { get => ital; set => ital = value; }
        public int MaxUrtartalom { get => maxUrtartalom; set => maxUrtartalom = value; }
        public int JelenlegiUrtartalom
        {
            get => jelenlegiUrtartalom;
            set
            {
                if (value > maxUrtartalom)
                {
                    jelenlegiUrtartalom = maxUrtartalom;
                }
                else
                {
                    jelenlegiUrtartalom = value;
                }
                if (jelenlegiUrtartalom == 0)
                {
                    ital = null;
                }
            }
        }
        public double Suly()
        {
            return (maxUrtartalom / 35.0) + jelenlegiUrtartalom;
        }
        public override string ToString()
        {
            return $"Palack, benne levo ital: {ital}, jelenleg {jelenlegiUrtartalom} ml van benne, maximum {maxUrtartalom} ml fer bele.";
        }
        public void HozzaOnt(Palack masikPalack)
        {
            if (masikPalack == null || masikPalack.jelenlegiUrtartalom == 0)
            {
                return;
            }

            JelenlegiUrtartalom += masikPalack.jelenlegiUrtartalom;

            if (ital == masikPalack.ital)
            {
                return;
            }

            if (ital == null)
            {
                ital = masikPalack.ital;
            }
            else
            {
                ital = "keverek";
            }
        }
    }
}
