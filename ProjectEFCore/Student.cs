﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ProjectEFCore
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int GradeId { get; set; }
        public Grade Grade { get; set; }
    }
}
