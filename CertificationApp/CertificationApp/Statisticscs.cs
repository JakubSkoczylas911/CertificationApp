using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationApp
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public int Count { get; private set; }
        public float Average
        {
            get
            {
                return this.Sum / this.Count;
            }
        }
        public char AverageLetter
        {
            get
            {
                switch (this.Average)
                {
                    case var average when average >= 8:
                        return 'A';
                    case var average when average >= 6:
                        return 'B';
                    case var average when average >= 4:
                        return 'C';
                    case var average when average >= 2:
                        return 'D';
                    default:
                        return 'E';
                }
            }
        }
        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }
        public void AddSatify(float satify)
        {
            this.Count++;
            this.Sum += satify;
            this.Min = Math.Min(satify, this.Min);
            this.Max = Math.Max(satify, this.Max);
        }


    }
}
