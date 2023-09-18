using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
        {

        }
        public override void ChooseGesture()
        {
            Console.WriteLine($"Options:\n Rock \n Paper \n Scissors \n Lizard \n Spock \n\n {name}, which do you choose?");
            this.chosenGesture = Console.ReadLine();
        }
    }
}
