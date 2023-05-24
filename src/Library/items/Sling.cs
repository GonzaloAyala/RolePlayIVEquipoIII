namespace RoleplayGame.Items
{
    /// <summary>
    /// Sling. Permite atacar.
    /// </summary>

    public class Sling : IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 20;
            }
        }
        public override string ToString()
        {
            return "Sling";
        }
    }
}