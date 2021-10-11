﻿using MyHomework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework.Models
{
    public class EnrollmentDetail
    {
        public int EnrollmentId { get; set; }

        public int ClassId { get; set; }
        public virtual Class Class { get; set; }
        public int StudentId { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
