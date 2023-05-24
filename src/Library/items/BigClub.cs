namespace RoleplayGame.Items
{
    /// <summary>
    /// Un garrote muy grande. Una rama enorme, o un árbol chico. Bastante impresionante que lo puedas usar como un arma.
    /// </summary>

    public class BigClub : IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 40;
            }
        }
        public override string ToString()
        {
            return "Big club";
        }
    }
}