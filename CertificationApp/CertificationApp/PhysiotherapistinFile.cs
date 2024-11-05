namespace CertificationApp
{
    public class PhysiotheraphistinFile : PhysiotherapistBase
        
    {
        public override event StifyAdddedDelegate SatifyAdded;
        private const string FileName = "satify.txt";
        public PhysiotheraphistinFile(string name, string surname, string sex) : base(name, surname, sex)
        {
        }

        public override void AddSatify(float satify)
        {
            if (satify >= 0 && satify <= 10)
            {
                using (var writer = File.AppendText(FileName))
                {
                    writer.WriteLine(satify);
                }
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
                this.AddSatify(satifyValue);
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
            var satifyFromFile = this.ReadSatifyFromFile();
            var result = this.CountStatistics(satifyFromFile);
            return result;
        }
        private List<float> ReadSatifyFromFile()
        {
            var satifys = new List<float>();
            if (File.Exists(FileName))
            {
                using (var reader = File.OpenText(FileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var satify = float.Parse(line);
                        satifys.Add(satify);
                        line = reader.ReadLine();

                    }
                }
            }
            return satifys;
        }
        private Statistics CountStatistics(List<float> satifys)
        {
            var statistics = new Statistics();
            foreach (var satify in satifys)
            {
                statistics.AddSatify(satify);
            }
            return statistics;
        }
    }
}
