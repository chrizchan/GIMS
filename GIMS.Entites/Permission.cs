using System;

namespace GIMS.Entities
{
    public class Permission
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public bool Deleted { get; set; }

        public int CreatedById { get; set; }

        public DateTime CreatedOn { get; set; }
        public int? ModifiedById { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}