﻿using AutoMapper;
using Promact.CustomerSuccess.Platform.Entities;
using Promact.CustomerSuccess.Platform.Services.Dtos;

namespace Promact.CustomerSuccess.Platform.ObjectMapping;

public class PlatformAutoMapperProfile : Profile
{
    public PlatformAutoMapperProfile()
    {
        /* Create your AutoMapper object mappings here */
        CreateMap<CreateProjectDto, Project>();
        CreateMap<UpdateProjectDto, Project>();
        CreateMap<Project, ProjectDto>().ReverseMap();
        //1st mapping
        CreateMap<CreateProjectBudgetDto, ProjectBudget>();
        CreateMap<UpdateProjectBudgetDto,ProjectBudget>();
        CreateMap<ProjectBudget, ProjectBudgetDto>().ReverseMap();
        //2nd mapping
        CreateMap<CreateAuditHistoryDto, AuditHistory>();
        CreateMap<UpdateAuditHistoryDto, AuditHistory>();
        CreateMap<AuditHistory,AuditHistoryDto>().ReverseMap();
        //3rd Mapping
        CreateMap<CreateVersionHistoryDto, VersionHistory>();
        CreateMap<UpdateVersionHistoryDto, VersionHistory>();
        CreateMap<VersionHistory, VersionHistoryDto>().ReverseMap();
        //4th Mapping
        CreateMap<CreateProjectDescriptionDto, ProjectDescription>();
        CreateMap<UpdateProjectDescriptionDto, ProjectDescription>();
        CreateMap<ProjectDescription, ProjectDescriptionDto>().ReverseMap();
        //5th Mapping
        CreateMap<CreateStakeHolderDto, StakeHolder>();
        CreateMap<UpdateStakeHolderDto, StakeHolder>();
        CreateMap<StakeHolder, StakeHolderDto>().ReverseMap();
        //6th Mapping
        CreateMap<CreateRiskProfileDto, RiskProfile>();
        CreateMap<UpdateRiskProfileDto, RiskProfile>();
        CreateMap<RiskProfile, RiskProfileDto>().ReverseMap();
        //7th Mapping
        CreateMap<CreateSprintDto, Sprint>();
        CreateMap<UpdateSprintDto, Sprint>();
        CreateMap<Sprint, SprintDto>().ReverseMap();
        //8th Mapping
       




    }
}
