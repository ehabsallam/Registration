using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Registration.Models
{
    public class idea_professor
    {
        public int id { set; get; }//dh 2l Id bta3 2l column

        public int idea_id_fk { set; get; }//foregnkey leh 2l idea bs 27tamal 2udam yt8er ^^

        public int professor_id_fk { set; get; }//foregnkey leh 2l professor bs 27tamal 2udam yt8er ^^

        public string accept_reject_idea { set; get; }
    
    }
}