using DropDown.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DropDown.Dtos
{
    public class FormDto
    {
        public List<QuestionModel> Questions { get; set; }
        public List<DropDownValueModel> DropDownValues { get; set; }
        public List<DropDownModel> DropDowns { get; set; }

        public FormDto()
        {
            Questions = new List<QuestionModel>();
            DropDownValues = new List<DropDownValueModel>();
            DropDowns = new List<DropDownModel>();
        }


    }
}
