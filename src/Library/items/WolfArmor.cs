namespace RoleplayGame.Items
{
    public class WolfArmor: IDefenseItem
    {
        public int DefensePower 
        {
             
            get
            {
                return  65;
            } 
        }

        
        public override string ToString()
        {
            return "Wolf Armor";
        }
    }
}