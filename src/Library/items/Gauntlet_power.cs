namespace RoleplayGame.Items
{
    public class Gauntlet_power: IAttackItem
    {
        
        public int AttackPower 
        {
            get
            {
                return  0;
            } 
        }
        public override string ToString()
        {
            return "Gauntlet Power";
        }
    }
}