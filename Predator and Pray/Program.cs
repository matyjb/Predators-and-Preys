using System;
using System.Threading;
/**
    PREDATOR AND PREY CELLULAR AUTOMATON
    The world is grid of cells, with 3 possibilities: Predator(Red), Prey(Green), or Empty(Black).
    Both predator and prey have a set health, that changes over time.
    The simulation works in steps, with the following rules:
    -for prey
        In every time step, a prey moves randomly to one of the four neighboring fields, provided it is empty. 
        Every prey has a predefined "breed time". On exceeding this time, it gives birth to a new prey in one of the neighboring cells, 
        provided this randomly selected cell is free (If not nothing happens).
        Breed time counter of both the original and the descendant prey will be reset to one. Technically prey never die. 
        They live until they reach the breed time, then they clone and both parent as well as offspring restart their life cycle.
            Prey prey move randomly to free neighboring cells
            Once the breed time is up a new prey spawns in a free neighboring cell
    -for predator
        Predators move randomly to fields that are either free or occupied by prey. Every round they lose one point of energy. 
        If they enter a field occupied by a prey they eat the prey and gain a defined amount of energy. 
        If the energy level drops below zero the predator dies. If the energy exceeds a predefined value predators create an offspring in a free neighboring field. 
        The energy is split evenly between the parent and the child.
            Predators move randomly to neighboring cells that are free or occupied by (non predator) prey.
            If the cell to which the predator is moving is occupied by other prey it is consumed. The energy of the predator increases by a predefined value.
            If the predator has enough energy it spawns offspring in a free neighboring cell.
            Predators lose a small fixed ammount of energy with every time step.
            A predator dies if its energy level drops to zero.
*/
namespace Predator_and_Prey
{
    class Program
    {
        public static void SimulationWindow()
        {
            Application PaP = new Application(new SFML.Window.VideoMode(1600, 900), "Predator and Prey")
            {
                SideSize = 7,
                PreyBreedHealth = 10,
                PredatorBreedHealth = 100,
                MaxHealth = 1000
            };
            PaP.Run();
        }
        static void Main(string[] args)
        {
            Thread simulationWindow = new Thread(new ThreadStart(SimulationWindow));
            simulationWindow.Start();
            
            // TODO settings in command prompt or winforms


        }
    }
}
