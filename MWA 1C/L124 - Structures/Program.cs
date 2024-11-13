using System;

namespace L124___Structures
{
    internal class Program
    {
        struct BathroomRequest
        {
            public string nameOfRequester;
            public bool approved;
            public int howDesperate;
        }

        static BathroomRequest handleRequest(BathroomRequest razig)
        {
            if (razig.howDesperate > 50)
            {
                razig.approved = true;
            }
            else
            {
                razig.approved = false;
            }

            return razig;
        }

        static void Main(string[] args)
        {
            BathroomRequest request1;

            request1.approved = false;
            request1.howDesperate = 30;
            request1.nameOfRequester = "Luke";

            BathroomRequest handledRequest = handleRequest(request1);

            Console.WriteLine(handledRequest.approved);
            Console.ReadKey();
        }
    }
}
