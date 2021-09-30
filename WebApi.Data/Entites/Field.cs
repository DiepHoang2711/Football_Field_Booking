using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Data.Entites
{
    public class Field
    {
        public int FieldId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal OriginPrice { get; set; }
        public string Address { get; set; }
        public string ImagePath { get; set; }
        public string ImageName { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Status { get; set; }
        public int GroupFieldForeinKey { get; set; }
        public GroupField GroupField { get; set; }

    }
}
