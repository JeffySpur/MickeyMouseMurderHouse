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
        public CharacterTemplate(string name, int age, string role)
        {
            Name = name;
            Age = age;
            Role = role;
        }
       
    public string Name { get; set; }
    public int Age { get; set; }
    public string Role { get; set; }
    }


}
