using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DropDown.Models
{
    public class DropDownValueModel : ItemModel
    {
        [ForeignKey("DropDownModel")]
        public int DropDownId { get; set; }

        public DropDownModel DropDown { get; set; }
    }
}
