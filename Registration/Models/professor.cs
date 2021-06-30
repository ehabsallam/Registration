using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Registration.Models
{
    public class professor
    {
        public int id { set; get; }//dh 2l Id bta3 2l column

        //[Required(ErrorMessage = "Invalid Name")]//dh message 2l error 2ly httl3li (validation)
        //[Display(Name = "professor name")]//dh 2l2sm 2li bytl3 feh 2l view
        public string professor_name { set; get; }//dh 2l name bta3 2l professor


        public int DeptID { get; set; }
        public Department Department { get; set; }
    }
}