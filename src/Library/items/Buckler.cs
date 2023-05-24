namespace RoleplayGame.Items
{
    /// <summary>
    /// Escudo redondeado de pequeño tamaño, más útil de lo que parece.
    /// </summary>
    public class Buckler : IDefenseItem
    {
        /// <summary>
        /// El poder de defensa.
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
            return "Buckler";
        }
    }
}