﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohaNotebook.Anderson.Entities.DbSet
{
    public abstract class BaseEntity
    {
        public Guid Id {  get; set; }
        public int Status { get; set; }
        public DateTime AddedData { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; }
    }
}
