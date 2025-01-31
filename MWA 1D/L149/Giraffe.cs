using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L149
{
    internal class Giraffe
    {
        public float length, tongueLength;
        public string nickname;
        public int age;
        public bool alive;

        public void TongueFight(Giraffe opponent)
        {
            while (alive && opponent.alive)
            {
                opponent.length -= tongueLength * age;

                length += opponent.tongueLength * opponent.age;

                if (length <= 0)
                {
                    alive = false;
                }

                if (opponent.length <= 0)
                {
                    opponent.alive = false;
                }
                Console.WriteLine("lick.");
            }

            if (alive)
            {
                Console.WriteLine(nickname + " won and is now "+length+" long!");
            } else
            {
                Console.WriteLine(opponent.nickname + " won and is now " + opponent.length + " long!");
            }
        }
    }
}
