﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Promact.CustomerSuccess.Platform.Services.Dtos
{
    public class CreateSprintDto
    {
        [ForeignKey("PhaseMilestone")]
        public Guid PhaseMilestoneId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public SprintStatus Status { get; set; }
        public required string Comments { get; set; }
        public required string Goals { get; set; }
        public int SprintNumber { get; set; }
    }
}
