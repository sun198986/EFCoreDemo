using System;
using System.Collections.Generic;

namespace Demo.Domain
{
    public class Club
    {

        public Club()
        {
            players = new List<Player>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public DateTime DateOfEstablishment { get; set; }

        public string History { get; set; }

        public League League { get; set; }

        public List<Player> players { get; set; }
    }
}
