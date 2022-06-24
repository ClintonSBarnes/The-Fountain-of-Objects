using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fountain_of_Objects
{
    internal class Dialogue
    {


        //dialogue statements:
        string dividerStars = "\n*************************************************************************************************************************\n";
        string dividerDashs = "\n-------------------------------------------------------------------------------------------------------------------------\n";
        string playerArmed;


        string pitHelp = "Look out for pits. You will feel a breeze if a pit is in an adjacent room." +
            "\nIf you enter a room with a pit, you will die";
        string maelstromsHelp = "Maelstroms are violent forces of sentient wind. Entering a room with one could transport you to any other location in the caverns." +
            "\nYou will be able to hear their growling and groaning in the nearby rooms.";
        string amaroksHelp = "Amaroks roam the caverns. Encountering one is certian death, but you can smell their rotten stench in nearby rooms.";
        string gettingArmedHelp = "You carry with you a bow and a quiver of arrows. You can use them to shoot monsters in the caverns but be warned:\nyou have a limited supply.";


        //dialogue methods
        public void Introduction()
        {

            Console.WriteLine($"{dividerStars}" +
            "You enter the Cavern of Objects, a maze of rooms filled with dangerous pits in search of the Fountains." +
            "\nLight is visible only in the entrance, and no other light is seen anywhere in the caverns." +
            "\nYou must navigate the Caverns with your other senses." +
            "\nFind the Fountains of Objects, activate it, and return to the entrance.");
        }

        public static void SelectBoardSize()
        {
            Console.WriteLine("What level of difficulty would you like? (E)asy, (A)dvanced, E(x)pert: ");

        }

        public static void PlayerMove()
        {

            Console.WriteLine("Where would you like to move? (N)orth, (S)outh, (E)ast, or (W)est: ");


        }

        public void PlayerStatus((int x, int y) playerLocation, RoomTrait trait, FountainState fountain)
        {
            
            string roomTraitDescription;
            string fountainDescription;

            Console.WriteLine($"{dividerDashs}You are in the room at (Row={playerLocation.x}, Column={playerLocation.y}"); //writes on each pull of this method.


            //determines room status statement to share with the user.
            if (fountain == FountainState.FountainOff)
            {
                fountainDescription = "You hear water dripping in this room. The Fountain of Objects is here!";
                Console.Write(fountainDescription);
            }
            if (fountain == FountainState.FountainOn)
            {
                fountainDescription = "You hear the rushing waters from the Fountain of Objects. It has been reactivated!";
                Console.Write(fountainDescription);
            }

            if (trait == RoomTrait.Pit)
            {
                roomTraitDescription = "You feel a draft. There is a pit in a nearby room.";
                Console.WriteLine(roomTraitDescription);

            }
            if (trait == RoomTrait.Maelstrom)
            {
                roomTraitDescription = "You hear the growling and groaning of a maelstrom nearby.";
                Console.WriteLine(roomTraitDescription);


            }
            if (trait == RoomTrait.Amaroks)
            {
                roomTraitDescription = "You can smell the rotten stench of an amarok in a nearby room.";
                Console.WriteLine(roomTraitDescription);

            }
            if (trait == RoomTrait.Entry)
            {
                roomTraitDescription = "You see light coming from the cavern entrance.";
                Console.WriteLine(roomTraitDescription);

            }

        }




    }


}
