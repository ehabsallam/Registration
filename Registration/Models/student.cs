using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Registration.Models
{
    public class student
    {
        public int id { set; get;}
        public string nameStd { set;get;}
        public int levelStd { set; get;}
        public int gbaStd { set; get;}
        public string skillStd { set; get;}      
        public teamLeader leader_fr { set; get;}
        public int frLeader { set; get;}
    }
}