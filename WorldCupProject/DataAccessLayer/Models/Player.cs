using DataAccessLayer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Player : IComparable<Player>
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("captain")]
        public bool Captain { get; set; }

        [JsonProperty("shirt_number")]
        public long ShirtNumber { get; set; }

        [JsonProperty("position")]
        public Position Position { get; set; }

        public int CompareTo(Player other)
        {
            return this.ShirtNumber.CompareTo(other.ShirtNumber);
        }

        public override bool Equals(object obj)
        {
            return obj is Player player &&
                   Name == player.Name &&
                   Captain == player.Captain &&
                   ShirtNumber == player.ShirtNumber &&
                   Position == player.Position;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Captain, ShirtNumber, Position);
        }

    }
}
