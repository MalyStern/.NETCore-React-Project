﻿using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string CourseName { get; set; } = null!;

    public int NumOfMeetings { get; set; }

    public int Price { get; set; }

    public int FieldId { get; set; }

    public virtual Field Field { get; set; } = null!;

    public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}
