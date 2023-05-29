using System;
using System.Collections.Generic;
using RoleplayGame.Items;

 public class Gauntlet_power : IAttackItem
    {
        private List<IAttackItem> gemas;

        public Gauntlet_power()
        {
            gemas = new List<IAttackItem>();
        }

        public void AgregarGema(IAttackItem gema)
        {
            gemas.Add(gema);
        }

        public int AttackPower
        {
            get
            {
                int attackPower = 0;
                foreach (IAttackItem gema in gemas)
                {
                    attackPower += gema.AttackPower;
                }
                return attackPower;
            }
        }

        public override string ToString()
        {
            return "Gauntlet Power";
        }
    }


