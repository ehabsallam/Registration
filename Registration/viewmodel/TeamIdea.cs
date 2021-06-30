using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Registration.Models;

namespace Registration.viewmodel
{
    public class TeamIdea
    {
        public student std { set; get; }
        public ideaTeam idea { set; get; }
        public teamLeader leader { set; get; }
        public professor pro { set; get; }
        public idea_professor ideapro { set; get; }
    }

}