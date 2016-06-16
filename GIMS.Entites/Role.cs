using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GIMS.Entities
{
	public class Role
	{
		
		public int Id { get; set; }
		
		[StringLength(50)]
		public string Name { get; set; }
		
		[StringLength(100)]
		public string Description { get; set; }
		
		public int CreatedById { get; set; }
	    public User CreatedBy { get; set; }
		
		public DateTime CreatedOn { get; set; }
		
		public int? ModifiedById { get; set; }
	    public User ModifiedBy { get; set; }
		
		public DateTime? ModifiedOn { get; set; }
		
		public bool Deleted { get; set; }

        public IList<RolePermission> RolePermissions { get; set; }

        public IList<UserRole> UserRoles { get; set; }


	}
}
	
