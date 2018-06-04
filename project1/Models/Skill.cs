using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project1.Models
{
   
        public class Skill
        {
            public int SkillId { get; set; }
            public string Skills { get; set; }

            public virtual ICollection<UserToSkill> UserToSkills { get; set; }

        }
    
}