namespace CertificationApp
{
    public interface IPhysiotherapist
    {
        string Name { get; }
        string Surname { get; }
        string Sex { get; }
        void AddSatify(float satify);
        void AddSatify(string satify);
        void AddSatify(char satify);
        Statistics GetStatistics();
    }
}
