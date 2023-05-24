namespace RoleplayGame.Items
{
    public class TowerShield : IDefenseItem
    {
        public int DefensePower
    {
        get
        {
            return 40;
        }
    }
            public override string ToString()
        {
            return "Tower Shield";
        }
    }
}