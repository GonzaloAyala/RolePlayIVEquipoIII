namespace RoleplayGame.Items
{
    public class ChainMail : IDefenseItem
    {
        public int DefensePower
    {
        get
        {
            return 25;
        }
    }
            public override string ToString()
        {
            return "Chain Mail";
        }
    }
}