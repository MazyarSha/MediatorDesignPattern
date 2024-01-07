using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    public class Beatle : Participant
    {
        public Beatle(string name): base(name) 
        {
            
        }

        public override void Recieve(string from, string message)
        {
            Console.Write("To a Beatle:");
            base.Recieve(from, message);
        }
    }
}
