namespace RoleplayGame.Items
{
    public class LeatherArmor: IDefenseItem
    {
        public int DefensePower 
        {
            get
            {
                return  5;
            } 
        }
        public override string ToString()
        {
            return "LeatherArmor";
        }
    }
}