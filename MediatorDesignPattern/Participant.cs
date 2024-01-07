using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    public class Participant
    {
        Chatroom chatroom;
        string name;
        public Participant(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
        }
        public Chatroom Chatroom 
        { 
            set { chatroom = value; } 
            get { return chatroom; } 
        }
        public void Send(Participant to, string message)
        {
            Chatroom.Send(name, to.name, message);
        }
        public virtual void Recieve(string from, string message)
        {
            Console.WriteLine("from {0} to {1}: '{2}'",from , Name, message);
        }
    }
}
