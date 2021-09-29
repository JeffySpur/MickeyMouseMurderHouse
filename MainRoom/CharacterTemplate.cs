using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainRoom
{
    public class CharacterTemplate
    {
        public CharacterTemplate() { }
        public CharacterTemplate(string name, string role)
        {
            Name = name;
            Role = role;
        }
       
    public string Name { get; set; }
    public string Role { get; set; }
    public string Testimony { get; set; }
    public string Testimony2 { get; set; }
    public string Testimony3 { get; set; }
    public string Testimony4 { get; set; }
    }
}


