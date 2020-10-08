using System;

namespace HMWK_SQLinCsharp_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Eng65Context())
            {
                Console.WriteLine(db.ContextId);
            }
        }
    }
}
