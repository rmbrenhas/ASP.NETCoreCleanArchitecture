﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities
{
    public abstract class Entity
    {
        public int Id { get; protected set; }


        /*         
        public DateTime CreatedDate { get; protected set; }
        public DateTime UpdatedDate { get; protected set; }
        public string CreatedBy { get; protected set; }
        public string UpdatedBy { get; protected set; }
         */
    }
}
