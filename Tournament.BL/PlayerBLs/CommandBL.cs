namespace Tournament.BL.PlayerBLs
{
    public interface ICommandBL
    {
        public void Validate();
        public bool Do();
    }
}