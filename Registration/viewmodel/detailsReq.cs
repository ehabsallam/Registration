using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Registration.viewmodel
{
    public class detailsReq
    {
        public int id { set; get; }
        public string ideaName { set; get; }
        public string ideaDesc { set; get; }
        public string ideaTools { set; get; }
        public string leaderName { set; get; }
        public string leaderSkill { set; get; }
        public int leaderGba { set; get; }
        public int leaderLevel { set; get; }
    }
}