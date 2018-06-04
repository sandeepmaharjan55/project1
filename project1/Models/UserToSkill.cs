using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project1.Models
{
    public class UserToSkill
    {
        public int UserToSkillId { get; set; }
        public int UserId { get; set; }
        public int SkillId { get; set; }



        public virtual User User { get; set; }
        public virtual Skill Skill { get; set; }


    }
}