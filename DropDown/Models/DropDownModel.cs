using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DropDown.Models
{
    
        public class DropDownModel : ItemModel
        {
            public List<DropDownValueModel> DropDownValue { get; set; }

            [ForeignKey("QuestionModel")]
            public int QuestionId { get; set; }
            public QuestionModel Question { get; set; }

        }
    
}
