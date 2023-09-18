using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class ComputerPlayer : Player
    {
        public ComputerPlayer() : base("Computer")
        {
        }
            
        public override void ChooseGesture()
        {
            Random ranGesture = new Random();
            int index = ranGesture.Next(gestures.Count);
            this.chosenGesture = this.gestures[index];
            
        }
    }
}
