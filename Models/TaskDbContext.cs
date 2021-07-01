using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Truck_Delivery_Tracking.Models
{
	public class TasksDbContext : DbContext
	{
		public TasksDbContext() : base("DefaultConnection")
		{

		}
		public DbSet<Tasks> Tasks { get; set; }

		public static TasksDbContext Create()
		{
			return new TasksDbContext();
		}
	}
}