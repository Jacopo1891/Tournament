namespace Tournament.Contracts.Commons
{
    public interface IEntityBase
    {
        public int Id { get; set; }
        public string LastEdit { get; set; }
    }
}
