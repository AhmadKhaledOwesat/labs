
using AutoMapper;
using JoLab.Application.Dto;
using JoLab.Application.Interfaces;
using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using Profile = AutoMapper.Profile;

namespace JoLab.Application.Mapper
{
    public class JoLabMapper : Profile, IJoLabMapper
    {
        private readonly IMapper _mapper;
        public JoLabMapper(IMapper mapper)
        {
            _mapper = mapper;
        }
        public JoLabMapper()
        {
            ClientMapperProfile();

            CreateMap<Users, UsersDto>().ReverseMap();
            CreateMap<PageResult<Users>, PageResult<UsersDto>>().ReverseMap();
            CreateMap<Setting, SettingDto>().ReverseMap();
            CreateMap<PageResult<Setting>, PageResult<SettingDto>>().ReverseMap();
            CreateMap<Role, RoleDto>().ReverseMap();
            CreateMap<PageResult<Role>, PageResult<RoleDto>>().ReverseMap();
            CreateMap<Privilege, PrivilegeDto>()
             .ForMember(dest => dest.ParentName, src => src.MapFrom(a => a.Parent == null ? string.Empty : a.Parent.PrivilegeName))
            .ReverseMap();
            CreateMap<PageResult<Privilege>, PageResult<PrivilegeDto>>().ReverseMap();
            CreateMap<UserRole, UserRoleDto>()
             .ForMember(dest => dest.UserName, src => src.MapFrom(a => a.User == null ? string.Empty : a.User.FullName))
             .ForMember(dest => dest.RoleName, src => src.MapFrom(a => a.Role == null ? string.Empty : a.Role.NameAr))
             .ReverseMap();
            CreateMap<PageResult<UserRole>, PageResult<UserRoleDto>>().ReverseMap();
            CreateMap<RolePrivilege, RolePrivilegeDto>()
          .ForMember(dest => dest.PrivilegeName, src => src.MapFrom(a => a.Privilege == null ? string.Empty : a.Privilege.PrivilegeName))
          .ForMember(dest => dest.RoleName, src => src.MapFrom(a => a.Role == null ? string.Empty : a.Role.NameAr))
          .ReverseMap();
            CreateMap<PageResult<RolePrivilege>, PageResult<RolePrivilegeDto>>()
                .ReverseMap();
            CreateMap<Report, ReportDto>().ReverseMap();
            CreateMap<PageResult<Report>, PageResult<ReportDto>>().ReverseMap();
            CreateMap<ReportParameter, ReportParameterDto>().ReverseMap();
            CreateMap<PageResult<ReportParameter>, PageResult<ReportParameterDto>>().ReverseMap();
        }

        public void ClientMapperProfile()
        {
            CreateMap<Client, ClientDto>().ReverseMap();
            CreateMap<PageResult<Client>, PageResult<ClientDto>>().ReverseMap();
        }

        public TDestination Map<TSource, TDestination>(TSource source) => _mapper.Map<TSource, TDestination>(source);

        public void Map<TSource, TDestination>(TSource source, TDestination destination) => Map(source, destination);

        public TDestination Map<TDestination>(object source) => _mapper.Map<TDestination>(source);
    }
}
