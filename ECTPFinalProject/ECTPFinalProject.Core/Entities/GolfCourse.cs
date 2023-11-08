﻿namespace ECTPFinalProject.Core.Entities
{
    public class GolfCourse
    {
        public int GolfCourseId { get; set; }
        public required string Name { get; set; }
        public List<Hole>? Holes { get; set; }
    }
}
