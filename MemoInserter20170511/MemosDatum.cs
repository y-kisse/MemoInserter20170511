using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoInserter20170511
{
    class MemosDatum
    {
        public DateTime date;
        public String tripDirection;
        public int? AC;
        public int? defroster;
        public int? timer;
        public int? CH;
        public int? startGids;
        public int? endGids;
        public double? averageElectricityExpense;
        public int? electricityExpenseReset;
        public String remarks;

        public void setDate(DateTime date)
        {
            this.date = date;
        }

        public void setTripDirection(String tripDirection)
        {
            this.tripDirection = tripDirection;
        }

        public void setAC(int? AC)
        {
            this.AC = AC;
        }

        public void setDefroster(int? defroster)
        {
            this.defroster = defroster;
        }

        public void setTimer(int? timer)
        {
            this.timer = timer;
        }

        public void setCH(int? CH)
        {
            this.CH = CH;
        }

        public void setStartGids(int? startGids)
        {
            this.startGids = startGids;
        }

        public void setEndGids(int? endGids)
        {
            this.endGids = endGids;
        }

        public void setAverageElectricityExpense(double? averageElectricityExpense)
        {
            this.averageElectricityExpense = averageElectricityExpense;
        }

        public void setElectricityExpenseReset(int? electricityExpenseReset)
        {
            this.electricityExpenseReset = electricityExpenseReset;
        }

        public void setRemarks(String remarks)
        {
            this.remarks = remarks;
        }

        public void setDatumByIndex(int index, Object datum)
        {
            switch (index)
            {
                case 1:
                    setDate((DateTime)datum);
                    break;
                case 2:
                    setTripDirection((String)datum);
                    break;
                case 3:
                    setAC((int?)(double?)datum);
                    break;
                case 4:
                    setDefroster((int?)(double?)datum);
                    break;
                case 5:
                    setTimer((int?)(double?)datum);
                    break;
                case 6:
                    setCH((int?)(double?)datum);
                    break;
                case 7:
                    setStartGids((int?)(double?)datum);
                    break;
                case 8:
                    setEndGids((int?)(double?)datum);
                    break;
                case 9:
                    setAverageElectricityExpense((double?)datum);
                    break;
                case 10:
                    setElectricityExpenseReset((int?)(double?)datum);
                    break;
                case 11:
                    setRemarks((String)datum);
                    break;
            }
        }
    }
}
