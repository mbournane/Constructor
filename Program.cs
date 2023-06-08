namespace Constructors;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Veuillez saisir le nombre d'étages: ");
        int nbFloors = Int32.Parse(Console.ReadLine());

        Console.Write("Veuillez saisir la taille du batiment: ");
        double size = Double.Parse(Console.ReadLine());

        Building fBuliding = new Building(nbFloors);

        Building sBulding = new Building(size,nbFloors);

        Console.WriteLine("La taille Maximum que peut faire un étage du bâtiment est {0}",fBuliding.GetFloorMaxSize());
        Console.WriteLine("Le nombre d'étages du bâtiment est {0}",sBulding.GetFloorCount());
        Console.WriteLine("La taille du batiment: {0}", fBuliding.GetSize());  
    }
}
