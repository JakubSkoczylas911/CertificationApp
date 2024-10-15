namespace CertificationApp.Tests
{
    public class Tests
    {
        [Test]
        public void IfAverageCountedByGivenSatifyInNumbersAverageIsCorrectAverageLetter()
        {

            var physiotheraphist = new PhysiotheraphistinFile("Jakub", "Burzyñski", "male");
            physiotheraphist.AddSatify(0);
            physiotheraphist.AddSatify(1);
            physiotheraphist.AddSatify(2);
            physiotheraphist.AddSatify(5);


            var statistics = physiotheraphist.GetStatistics();
            Assert.AreEqual(statistics.AverageLetter, 'D');
        }
    }
}