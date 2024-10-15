using CertificationApp ;
Console.WriteLine("Witamy w programie do oceny usatysfakcjonowania z pracy fizjoterapeuty");
Console.WriteLine("=======================================");
Console.WriteLine();
var physiotheraphist = new PhysiotheraphistinFile("Jakub", "Burzyński", "male");
physiotheraphist.SatifyAdded += PhysiotherapistScoreAded;

void PhysiotherapistScoreAded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}


while (true)
{
    Console.WriteLine("Podaj kolejny stopień ustysfakcjonowania z pracy fizjoterapety,gdzie 0 to fatalnie, a 10 to fantastycznie?lub wprowadź q by poznać dotychczasowe statystyki");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        physiotheraphist.AddSatify(input);
    }
    catch (Exception e)
    {

        Console.WriteLine($"Exeption catched:{e.Message}");
    }
}

var statistics = physiotheraphist.GetStatistics();
Console.WriteLine($"Ocena najniższa:{statistics.Min}");
Console.WriteLine($"Ocena najwyższa:{statistics.Max}");
Console.WriteLine($"Ocena średnia:{statistics.Average:N2}");
Console.WriteLine($"średnia ocen wyrażona literą:{statistics.AverageLetter}");