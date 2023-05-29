namespace RoleplayGame.Items
{
    public class Gema: IAttackItem
    {
        public int AttackPower 
        {
            get
            {
                return  10;
            } 
        }
        public override string ToString()
        {
            return "Gema";
        }
    }
}