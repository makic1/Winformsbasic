namespace WineCardAppVersionFour.Entities
{
    public class Vintage
    {
        public int VintageId { get; set; }

        public int VintageYear { get; set; }

        public ICollection<Wine> Wines { get; set; } = new List<Wine>();

        public override string ToString()
        {
            return Convert.ToString(VintageYear);
        }
    }
}
