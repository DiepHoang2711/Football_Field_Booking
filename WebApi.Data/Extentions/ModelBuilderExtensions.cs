using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Data.Entites;

namespace WebApi.Data.Extentions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<GroupField>().HasData(
                new GroupField()
                {
                    Name = "Hoang",
                    Address = "HN",
                    GroupFieldId = 1,
                    Status = true
                },

                new GroupField()
                {
                    Name = "VanTam",
                    Address = "HN",
                    GroupFieldId = 2,
                    Status = true
                }, new GroupField()
                {
                    Name = "MinhAnh",
                    Address = "HN",
                    GroupFieldId = 3,
                    Status = true
                });

            modelBuilder.Entity<Field>().HasData(
                new Field()
                {
                    FieldId = 1,
                    Name = "A",
                    Address = "HN",
                    GroupFieldForeinKey = 1,
                    Status = true
                },
                new Field()
                {
                    FieldId = 2,
                    Name = "A",
                    Address = "HN",
                    GroupFieldForeinKey = 2,
                    Status = true
                },
                new Field()
                {
                    FieldId = 3,
                    Name = "A",
                    Address = "HN",
                    GroupFieldForeinKey = 3,
                    Status = true
                }
                );



        }
    }
}
