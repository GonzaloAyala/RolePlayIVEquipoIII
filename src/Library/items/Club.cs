namespace RoleplayGame.Items
{
    /// <summary>
    /// Garrote. Honestamente, el típico palo que encontrarías tirado, ni siquiera es muy pesado.
    /// </summary>

    public class Club : IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 10;
            }
        }
        public override string ToString()
        {
            return "Club";
        }
    }
}