using AS2223_4G_INF_HavrylovDanyil_SlitaLibrary;

namespace AS2223_4G_INF_HavrylovDanyil_SlitaVisual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sled n = new Sled(13, 13);
            n.AddGift(new Gift("C4", "Blu", 4, 13));
        }
    }
}