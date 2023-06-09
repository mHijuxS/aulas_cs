using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ExVect
{
    internal class Registry
    {
        public string Name { get; private set; }
        public int Room { get; private set; }

        public string Mail { get; private set; }

        public Registry(string name, int room, string mail)
        {
            Name = name;
            Room = room;
            Mail = mail;
        }

    }
}
