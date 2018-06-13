using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoInserter20170511
{
    class MemosDatum
    {
        public int experimentId;
        public int gids;
        public int soh;
        public double temperature;
        public double packT1C;
        public double packT2C;
        public double packT3C;
        public double packT4C;
        public double correctedGids;
        public double correctedEnergy;

        public void setExperimentId(int experimentId)
        {
            this.experimentId = experimentId;
        }

        public void setGids(int gids)
        {
            this.gids = gids;
        }

        public void setSoh(int soh)
        {
            this.soh = soh;
        }

        public void setTemperature(double temperature)
        {
            this.temperature = temperature;
        }

        public void setPackT1C(double packT1C)
        {
            this.packT1C = packT1C;
        }

        public void setPackT2C(double packT2C)
        {
            this.packT2C = packT2C;
        }

        public void setPackT3C(double packT3C)
        {
            this.packT3C = packT3C;
        }

        public void setPackT4C(double packT4C)
        {
            this.packT4C = packT4C;
        }

        public void setCorrectedGids(double correctedGids)
        {
            this.correctedGids = correctedGids;
        }

        public void setCorrectedEnergy(double correctedEnergy)
        {
            this.correctedEnergy = correctedEnergy;
        }

        public void setDatumByIndex(int index, Object datum)
        {
            switch (index)
            {
                case 1:
                   setExperimentId((int)(double)datum);
                    break;
                case 2:
                    setGids((int)(double)datum);
                    break;
                case 3:
                    setSoh((int)(double)datum);
                    break;
                case 4:
                    setTemperature((double)datum);
                    break;
                case 5:
                    setPackT1C((double)datum);
                    break;
                case 6:
                    setPackT2C((double)datum);
                    break;
                case 7:
                    setPackT3C((double)datum);
                    break;
                case 8:
                    setPackT4C((double)datum);
                    break;
                case 9:
                    setCorrectedGids((double)datum);
                    break;
                case 10:
                    setCorrectedEnergy((double)datum);
                    break;
             }
        }
    }
}
