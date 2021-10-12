using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
