namespace RoleplayGame.Items
{
    /// <summary>
    /// Coca-Cola Shield. Una chapita de cocacola del tamaño de un plato y modificada para ser utilizada como un escudo.
    /// </summary>
    public class CocaColaShield : IDefenseItem
    {
        /// <summary>
        /// El poder de defensa.
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 5;
            }
        }

        public override string ToString()
        {
            return "Coca-Cola shield®";
        }
    }
}