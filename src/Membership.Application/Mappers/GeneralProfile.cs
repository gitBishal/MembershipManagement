using AutoMapper;
using Membership.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership.Application.Mappers
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Core.Entities.Membership,AddOrUpdateMembershipViewModel>().ReverseMap();    
            CreateMap<Core.Entities.Membership,MembershipViewModel>().ReverseMap();    
        }
    }
}
