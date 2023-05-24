namespace RoleplayGame.Items
{
    /// <summary>
    /// Escudo Coca-Cola. Una chapita de cocacola del tamaño de un plato y 
    /// modificada para ser utilizada como un escudo. 
    /// Un artefacto mágico que crea piedras en los riñones del atacante.
    /// </summary>
    public class CocaColaShield : IAttackItem, IDefenseItem
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

        /// <summary>
        /// El poder de defensa
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 12;
            }
        }

        public override string ToString()
        {
            return "Coca-Cola shield®";
        }
    }
}