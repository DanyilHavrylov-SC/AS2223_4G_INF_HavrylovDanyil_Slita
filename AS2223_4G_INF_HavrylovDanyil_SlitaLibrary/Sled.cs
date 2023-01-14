namespace AS2223_4G_INF_HavrylovDanyil_SlitaLibrary
{
    public class Sled
    {
        double maxVolume, maxWeight;
        List<Gift> gifts;
        public Sled(double maxVolume, double maxWeight)
        {
            this.maxVolume = maxVolume;
            this.maxWeight = maxWeight;
            gifts = new List<Gift>();
        }

        public bool AddGift(Gift gift)
        {
            double totVolume = 0, totWeight = 0;
            gifts.Add(gift);
            foreach (Gift n in gifts)
            {

            }
            return false;
        }
    }
}