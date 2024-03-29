﻿using System.ComponentModel.DataAnnotations;

namespace Promact.CustomerSuccess.Platform.Services.Dtos
{
    public class CreateRiskProfileDto
    {
        public Guid ProjectId { get; set; }

        public RiskType RiskType { get; set; }

        public RiskSeverity Severity { get; set; }

        public RiskImpact Impact { get; set; }

        public virtual ICollection<RemediationStepDto> RemediationSteps { get; set; }

        public virtual ProjectDto Project { get; set; }
    }
}
