using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    public class Chatroom : AbstractChatroom
    {
        private Dictionary<string, Participant> participants = new Dictionary<string, Participant>();

        public override void Register(Participant participant)
        {
            if (!participants.ContainsValue(participant))
            {
                participants[participant.Name] = participant;
            }
            participant.Chatroom = this;
        }

        public override void Send(string from, string to, string message)
        {
            Participant participant = participants[to];
            if (participant != null) 
            {
                participant.Recieve(from, message);
            }
        }
    }
}
