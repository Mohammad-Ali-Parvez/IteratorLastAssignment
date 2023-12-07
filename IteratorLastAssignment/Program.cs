using IteratorAndCompositeExercise.Menus;
using System.Collections;
using System.Drawing;

namespace IteratorAndCompositeExercise
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // Menu classes instances create 
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();

            // Create a Waitress and pass the menus to it
            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu);

            // Combined menu print
            waitress.PrintMenu();

        }
    }
}
