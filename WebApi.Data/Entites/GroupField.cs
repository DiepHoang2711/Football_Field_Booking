using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Data.Entites
{
    public class GroupField
    {
        public int GroupFieldId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }
        public string ImagePath { get; set; }
        public string ImageName { get; set; }
        public DateTime DateCreated { get; set; }
        public ICollection<Field> Fields { get; set; }
    }
}
