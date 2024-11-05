namespace CertificationApp
{
    public abstract class PhysiotherapistBase : IPhysiotherapist
    {
        public delegate void StifyAdddedDelegate(object sender, EventArgs args);
        public abstract event StifyAdddedDelegate SatifyAdded;
        public PhysiotherapistBase(string name, string surname, string sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Sex { get; private set; }
        public abstract void AddSatify(float satify);
        public abstract void AddSatify(string satify);
        public abstract void AddSatify(char satify);
        public abstract Statistics GetStatistics();
    }
}