namespace CertificationApp
{
    public  class PhysiotherapistinMemory: PhysiotherapistBase
    {
        public override event StifyAdddedDelegate SatifyAdded;
        private List<float> satifys = new List<float>();
        public PhysiotherapistinMemory(string name, string surname, string sex) : base(name, surname, sex)
        {

        }

        public override void AddSatify(float satify)
        {
            if (satify >= 0 && satify <= 10)
            {
                this.AddSatify(satify);
                if (SatifyAdded != null)
                {
                    SatifyAdded(this, new EventArgs());
                }
            }

            else
            {
                throw new Exception("invalid satify value");
            }
        }

        public override void AddSatify(string satify)
        {
            if (float.TryParse(satify, out float satifyValue))
            {
                this.AddSatify(satifyValue);
            }
            else if (char.TryParse(satify, out char charValue))
            {
                this.AddSatify(charValue);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }


        public override void AddSatify(char satify)
        {
            switch ((float)satify)
            {
                case 'A':
                case 'a':
                    this.AddSatify(10);
                    break;
                case 'B':
                case 'b':
                    this.AddSatify(8);
                    break;
                case 'C':
                case 'c':
                    this.AddSatify(6);
                    break;
                case 'D':
                case 'd':
                    this.AddSatify(4);
                    break;
                case 'E':
                case 'e':
                    this.AddSatify(2);
                    break;
                default:
                    throw new Exception("Wrong letter");


            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            foreach (var satify in this.satifys)
            {
                statistics.AddSatify(satify);
            }


            return statistics;
        }
    }
}
