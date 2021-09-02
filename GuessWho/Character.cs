using System;
using System.Collections.Generic;
using System.Text;

namespace GuessWho
{
    class Character
    {
        public string name;
        public string hair;
        public string eyes;
        public string height;

        public Character(string aName)
        {
            int intHair;
            int intEyes;
            int intHeight;

            Random rnd = new Random();

            intHair = rnd.Next(0, 2);
            intEyes = rnd.Next(0, 2);
            intHeight = rnd.Next(0, 2);

            name = aName;

            if (intHair == 0)
            {
                hair = " has brown hair;";
            }
            else
            {
                hair = " has blond hair;";
            }

            if (intEyes == 0)
            {
                eyes = " has brown eyes;";
            }
            else
            {
                eyes = " has blue eyes;";
            }

            if (intHeight == 0)
            {
                height = " and is tall";
            }
            else
            {
                height = " and is short";
            }
        }
    }
}
