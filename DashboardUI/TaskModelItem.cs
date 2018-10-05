namespace DashboardUI
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using DashboardUI.Models;

    public partial class TaskModelItem : DbContext
    {
        public TaskModelItem()
            : base("name=TelevisionShowConnection")
        {
        }

        public virtual DbSet<TaskModel> taskItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskModel>()
                .Property(e => e.pk_TaskID);

            modelBuilder.Entity<TaskModel>()
                .Property(e => e.TaskTitle)
                .IsUnicode(false);

            modelBuilder.Entity<TaskModel>()
                .Property(e => e.TaskStartTime);

            modelBuilder.Entity<TaskModel>()
                .Property(e => e.TaskEndTime);

            modelBuilder.Entity<TaskModel>()
                .Property(e => e.fk_TaskPriority);

            modelBuilder.Entity<TaskModel>()
                .Property(e => e.fk_ParentTaskID);

            modelBuilder.Entity<TaskModel>()
                .Property(e => e.fk_TaskStatus);

            modelBuilder.Entity<TaskModel>()
                .Property(e => e.fk_TaskOwner);

            modelBuilder.Entity<TaskModel>()
                .Property(e => e.TaskDetails);

            modelBuilder.Entity<TaskModel>()
                .Property(e => e.fk_TaskType);

        }
    }
}
