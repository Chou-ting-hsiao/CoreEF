﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoreEF.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Age { get; set; }

        public int ClassID { get; set; }

        //[ForeignKey("ClassID")]
        public Class Class { get; set; }

        public Class Class2 { get; set; }


    }
}