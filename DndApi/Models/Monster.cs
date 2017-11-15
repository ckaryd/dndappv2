using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDApi.Models
{
    public class Monster
    {
        public int id { get; set; }
        public string name { get; set; }
        public string size { get; set; }
        public string type { get; set; }
        public string subtype { get; set; }
        public string alignment { get; set; }
        public int armor_class { get; set; }
        public int hit_points { get; set; }
        public string hit_dice { get; set; }
        public string speed { get; set; }
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int constitution { get; set; }
        public int intelligence { get; set; }
        public int wisdom { get; set; }
        public int charisma { get; set; }
        public int dexterity_save { get; set; }
        public int wisdom_save { get; set; }
        public int charisma_save { get; set; }
        public int perception { get; set; }
        public int stealth { get; set; }
        public string damage_vuln { get; set; }
        public string damage_res { get; set; }
        public string damage_immu { get; set; }
        public string condition_immu { get; set; }
        public string senses { get; set; }
        public string languages { get; set; }
        public int challenge_rating { get; set; }
        public string special_abilities { get; set; }
        public string actions { get; set; }
    }
}
