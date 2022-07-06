namespace MarketSimLib
{
    public class Market
    {
        private List<Listing> listings;
        public Market()
        {
            listings = new List<Listing>();

        }

        public List<Listing> GetListingsOnMarket()
        {
            return listings;
        }

        public void AddListing(Listing l)
        {
            this.listings.Add(l);
        }

        public bool RemoveListing(Listing l)
        {
            return listings.Remove(l);
        }

    }
}