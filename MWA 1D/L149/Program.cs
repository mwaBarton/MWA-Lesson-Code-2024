using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L149
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Giraffe geoffreyee = new Giraffe();
            geoffreyee.alive = true;
            geoffreyee.nickname = "geoff";
            geoffreyee.age = 10;
            geoffreyee.tongueLength = 50;
            geoffreyee.length = 25;

            Giraffe godfrey = new Giraffe();
            godfrey.alive = true;
            godfrey.nickname = "dead godfrey";
            godfrey.age = -8;
            godfrey.tongueLength = 0;
            godfrey.length = 7006;

            geoffreyee.TongueFight(godfrey);

            Console.ReadKey();
        }
    }
}
