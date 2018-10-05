using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DashboardUI.Models
{
    [Table("sdnTaskQueue")]
    public class TaskModel
    {
        [Key]
        [Editable(false)]
        [DisplayName("Task ID")]
        public int pk_TaskID { get; set; }

        [Editable(true)]
        [DisplayName("Task Title")]
        public string TaskTitle { get; set; }

        [Editable(false)]
        [DisplayName("Begin Timestamp")]
        public DateTime TaskStartTime { get; set; }

        [Editable(true)]
        [DisplayName("Finish Timestamp")]
        public DateTime TaskEndTime { get; set; }

        [Editable(true)]
        [DisplayName("Task Priority")]
        public int fk_TaskPriority { get; set; }

        [Editable(true)]
        [DisplayName("Task Type")]
        public int fk_TaskType { get; set; }

        [Editable(true)]
        [DisplayName("Parent Task")]
        public int fk_ParentTaskID { get; set; }

        [Editable(true)]
        [DisplayName("Task Status")]
        public int fk_TaskStatus { get; set; }

        [Editable(true)]
        [DisplayName("Task Owner")]
        public int fk_TaskOwner { get; set; }

        [Editable(true)]
        [DisplayName("Task Details")]
        public string TaskDetails { get; set; }

        public TaskModel()
        {

        }

    }
}