using RoleplayGame.Characters;
using RoleplayGame;
using RoleplayGame.Encounters;
using System;
namespace RoleplayGame.Scenarios

{
    public class Escenario1 : IScenario
    {
    
    public void Setup()
    {
        //quise crear aca los pj pero no los tomaba en el run


    }
    public void Run()
    {
        Character Fede = new Trolls("Fede");
        Character Cris = new Elf("Cris");
        Character Ayala = new Wizard("Ayala");
        Character Eli = new Elf("Eli");
        
        Encounter Batalla = new AttackEncounter(Fede, Ayala);
        Encounter Batalla2 = new AttackEncounter(Cris, Eli);
       

        Batalla.DoEncounter();
        Batalla2.DoEncounter();
        if (Fede.IsDead)
        {
            Ayala.Health=80;
            if (Cris.IsDead)
            {
                Eli.Health=120;
                Encounter Batalla3 = new AttackEncounter(Ayala, Eli);
                Batalla3.DoEncounter();
                if (Eli.IsDead)
                {
                    Console.WriteLine("Ayala se declara victorioso de la Tierra Media");
                }
                else
                {
                    Console.WriteLine("Eli se declara victorioso de la Tierra Media");
                }
            }
            else 
            {
                Cris.Health=120;
                Encounter Batalla3 = new AttackEncounter(Ayala, Cris);
                Batalla3.DoEncounter();
                if (Cris.IsDead)
                {
                    Console.WriteLine("Ayala se declara victorioso de la Tierra Media");
                }
                else
                {
                    Console.WriteLine("Cris se declara victorioso de la Tierra Media");
                }
            }
        }
        else
        {
            Fede.Health=150;
            if (Cris.IsDead)
            {
                Eli.Health=120;
                Encounter Batalla3 = new AttackEncounter(Fede, Eli);
                Batalla3.DoEncounter();
                if (Eli.IsDead)
                {
                    Console.WriteLine("Fede se declara victorioso de la Tierra Media");

                }
                else
                {
                    Console.WriteLine("Eli se declara victorioso de la Tierra Media");

                }
            }
            else 
            {
                Cris.Health=120;
                Encounter Batalla3 = new AttackEncounter(Fede, Cris);
                Batalla3.DoEncounter();
                if (Cris.IsDead)
                {
                    Console.WriteLine("Fede se declara victorioso de la Tierra Media");

                }
                else
                {
                    Console.WriteLine("Cris se declara victorioso de la Tierra Media");

                }
            }
            
        }

        
        
       //+ "");
        

    }

    }
}