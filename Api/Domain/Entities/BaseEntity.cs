using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    class BaseEntity
    {
        public Guid ID { get; set; }

        private DateTime? _createAt;

        public DateTime? CreateAt
        {
            get { return _createAt; }
            set { _createAt = _createAt == null ? DateTime.UtcNow : value; }
        }

        public DateTime UpdateAt { get; set; }
    }
}
