using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Users
{
    public class User : IEntity {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UserName { get; set; }
    }
}
