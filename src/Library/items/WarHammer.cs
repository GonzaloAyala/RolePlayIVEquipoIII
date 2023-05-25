namespace RoleplayGame.Items
{
    /// <summary>
    /// Un Martillo de guerra. Parece algo que usaría un enano.
    /// </summary>

    public class WarHammer : IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 25;
            }
        }
        public override string ToString()
        {
            return "War Hammer";
        }
    }
}