using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Registration.Models
{

        public class users
        {
            public int id { set; get; }//dh 2l Id bta3 2l column

            [Required(ErrorMessage = "Invalid Name")]//dh message 2l error 2ly httl3li (validation)
            [Display(Name = "User_name")]//dh 2l2sm 2li bytl3 feh 2l view
            public string user_name { set; get; }//dh 2l Email bta3 2l user

            [Required(ErrorMessage = "Invalid password")]//dh message 2l error 2ly httl3li (validation)
            [Display(Name = "User_name")]//dh 2l2sm 2li bytl3 feh 2l view
            public string user_password { set; get; }//dh 2lpassword bta3 2l user

            [Required(ErrorMessage = "Invalid password")]//dh message 2l error 2ly httl3li (validation)
            [Display(Name = "User_name")]//dh 2l2sm 2li bytl3 feh 2l view
            public int user_type { set; get; }//dh admin wla proffesor wla student

        }
    }
