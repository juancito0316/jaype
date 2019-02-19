using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Categories
{
    public class Category : IEntity {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
