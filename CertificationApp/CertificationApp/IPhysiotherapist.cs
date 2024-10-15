using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
