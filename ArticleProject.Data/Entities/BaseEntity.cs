using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Data.Entity
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreatedBy = "Admin";
            CreatedDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            UpdatedBy = "Admin";
            UpdatedDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }

        public int ID { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
