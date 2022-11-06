using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_TicTacToe
{
    /// <summary>
    /// this class is for the computer player.
    /// </summary>
    public class SimpleKIPlayer
    {
        const int buttonsCount = 9;

        private List<Button> buttons;

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="buttons">all 9 buttons of the game</param>
        /// <exception cref="Exception">exception thrown on wrong button count</exception>
        public SimpleKIPlayer(List<Button> buttons)
        {
            this.buttons = buttons;

            if (buttons.Count != buttonsCount)
                throw new Exception("Invalid buttons count!");
        }

        private bool MoveIsPossible()
        {
            foreach(var button in buttons)
            {
                if(button.Text == "")
                    return true;
            }
            return false;
        }

        /// <summary>
        /// This method executes the computer's next turn.
        /// </summary>
        /// <exception cref="Exception">Exception thrown if there is no possible move</exception>
        public void Move()
        {
            if (!MoveIsPossible())
                throw new Exception("there is no possible move");

            int buttonIndex = 0;
            var rand = new Random(); 
            do
            {
                buttonIndex = rand.Next(buttons.Count);
            } while (buttons.ElementAt(buttonIndex).Text != "");

            buttons.ElementAt(buttonIndex).Text = "O";
        }
    }
}
