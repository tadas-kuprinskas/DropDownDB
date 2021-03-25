using DropDown.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DropDown.Data
{
    public class DataContext : DbContext
    {
        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<DropDownModel> DropDowns { get; set; }
        public DbSet<DropDownValueModel> DropDownValues { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            if (!Questions.Any())
            {
                Questions.Add(new QuestionModel()
                {
                    //Id = 1,
                    Name = "Reikia atlikti rangos darbus"
                });
                Questions.Add(new QuestionModel()
                {
                    //Id = 2,
                    Name = "Rangos darbos atliks"
                });
                Questions.Add(new QuestionModel()
                {
                    //Id = 3,
                    Name = "Verslo klientas"
                });
                Questions.Add(new QuestionModel()
                {
                    //Id = 4,
                    Name = "Skaiciavimo budas"
                });
                Questions.Add(new QuestionModel()
                {
                    //Id = 5,
                    Name = "Svarbus klientas"
                });
                SaveChanges();

                if (!DropDowns.Any())
                {
                    DropDowns.Add(new DropDownModel()
                    {
                        //Id = 1,
                        Name = "Reikia atlikti rangos darbus",
                        QuestionId = 1
                    });
                    DropDowns.Add(new DropDownModel()
                    {
                        //Id = 2,
                        Name = "Rangos darbos atliks",
                        QuestionId = 2
                    });
                    DropDowns.Add(new DropDownModel()
                    {
                        //Id = 3,
                        Name = "Verslo klientas",
                        QuestionId = 3
                    });
                    DropDowns.Add(new DropDownModel()
                    {
                        //Id = 4,
                        Name = "Skaiciavimo budas",
                        QuestionId = 4
                    });
                    DropDowns.Add(new DropDownModel()
                    {
                        //Id = 5,
                        Name = "Svarbus klientas",
                        QuestionId = 5
                    });
                    SaveChanges();
                }

                if (!DropDownValues.Any())
                {
                    DropDownValues.Add(new DropDownValueModel()
                    {
                        //Id = 1,
                        Name = "Paprastas klientas",
                        DropDownId = 1
                    });
                    DropDownValues.Add(new DropDownValueModel()
                    {
                        //Id = 2,
                        Name = "Svarbus klientas",
                        DropDownId = 1
                    });
                    DropDownValues.Add(new DropDownValueModel()
                    {
                        //Id = 3,
                        Name = "",
                        DropDownId = 1
                    });
                    DropDownValues.Add(new DropDownValueModel()
                    {
                        //Id = 4,
                        Name = "Rankinis",
                        DropDownId = 2

                    });
                    DropDownValues.Add(new DropDownValueModel()
                    {
                        //Id = 5,
                        Name = "Automatinis",
                        DropDownId = 2

                    });
                    DropDownValues.Add(new DropDownValueModel()
                    {
                        //Id = 6,
                        Name = "Taip",
                        DropDownId = 3
                    });
                    DropDownValues.Add(new DropDownValueModel()
                    {
                        //Id = 7,
                        Name = "Ne",
                        DropDownId = 3
                    });
                    DropDownValues.Add(new DropDownValueModel()
                    {
                        //Id = 8,
                        Name = "Kiti rangovai",
                        DropDownId = 4
                    });
                    DropDownValues.Add(new DropDownValueModel()
                    {
                        //Id = 9,
                        Name = "Mėnesio rangovas",
                        DropDownId = 4
                    });
                    DropDownValues.Add(new DropDownValueModel()
                    {
                        //Id = 10,
                        Name = "Metinis rangovas",
                        DropDownId = 4
                    });
                    DropDownValues.Add(new DropDownValueModel()
                    {
                        //Id = 11,
                        Name = "Ne",
                        DropDownId = 5
                    });
                    DropDownValues.Add(new DropDownValueModel()
                    {
                        //Id = 12,
                        Name = "Taip",
                        DropDownId = 5
                    });
                    SaveChanges();
                }
            }

        }
    }
}
