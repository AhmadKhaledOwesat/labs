
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
            CityMapperProfile();
            ClientFileMapperProfile();
            UserMapperProfile();
            SettingMapperProfile();
            RoleMapperProfile();
            PrivilegedMapperProfile();
            UserRoleMapperProfile();
            RolePrivilegeMapperProfile();
            ReportMapperProfile();
            ReportParameterMapperProfile();
            ClientIndicatorMapperProfile();
            ClientInsuranceMapperProfile();
            ClientTestMapperProfile();
            CountryMapperProfile();
            TestMapperProfile();
            IndicatorMapperProfile();
            OrderMasterMapperProfile();
            OrderDetailsMapperProfile();
            SpecialtyMapperProfile();
            DoctorMapperProfile();
            TestInsurancePlanMapperProfile();
            TestNormalRangeMapperProfile();
        }
        private void TestMapperProfile()
        {
            CreateMap<Test, TestDto>()
             .ForMember(destination => destination.TubeTypeName, src => src.MapFrom(a => a.TubeType == null ? string.Empty : a.TubeType.NameOt))
             .ReverseMap();
            CreateMap<PageResult<Test>, PageResult<TestDto>>().ReverseMap();
        }

        private void TestInsurancePlanMapperProfile()
        {
            CreateMap<TestInsurancePlan, TestInsurancePlanDto>()
             .ForMember(destination => destination.TestName, src => src.MapFrom(a => a.Test == null ? string.Empty : a.Test.NameOt))
             .ForMember(destination => destination.InsuranceCompanyName, src => src.MapFrom(a => a.InsuranceCompany == null ? string.Empty : a.InsuranceCompany.NameOt))
             .ReverseMap();
            CreateMap<PageResult<TestInsurancePlan>, PageResult<TestInsurancePlanDto>>().ReverseMap();
        }

        private void TestNormalRangeMapperProfile()
        {
            CreateMap<TestNormalRange, TestNormalRangeDto>()
             .ForMember(destination => destination.TestName, src => src.MapFrom(a => a.Test == null ? string.Empty : a.Test.NameOt))
             .ReverseMap();
            CreateMap<PageResult<TestNormalRange>, PageResult<TestNormalRangeDto>>().ReverseMap();
        }
        private void DoctorMapperProfile()
        {
            CreateMap<Doctor, DoctorDto>()
             .ForMember(destination => destination.SpecialtyName, src => src.MapFrom(a => a.Specialty == null ? string.Empty : a.Specialty.NameOt))
             .ReverseMap();
            CreateMap<PageResult<Doctor>, PageResult<DoctorDto>>().ReverseMap();
        }
        private void OrderMasterMapperProfile()
        {
            CreateMap<OrderMaster, OrderMasterDto>()
             .ForMember(destination => destination.DoctorName, src => src.MapFrom(a => a.Doctor == null ? string.Empty : a.Doctor.NameOt))
             .ReverseMap();
            CreateMap<PageResult<OrderMaster>, PageResult<OrderMasterDto>>().ReverseMap();
        }
        private void OrderDetailsMapperProfile()
        {
            CreateMap<OrderDetails, OrderDetailsDto>()
             .ForMember(destination => destination.TestName, src => src.MapFrom(a => a.Test == null ? string.Empty : a.Test.NameOt))
             .ReverseMap();
            CreateMap<PageResult<OrderDetails>, PageResult<OrderDetailsDto>>().ReverseMap();
        }
        private void CountryMapperProfile()
        {
            CreateMap<Country, CountryDto>()
             .ReverseMap();
            CreateMap<PageResult<Country>, PageResult<CountryDto>>().ReverseMap();
        }
        private void SpecialtyMapperProfile()
        {
            CreateMap<Specialty, SpecialtyDto>()
             .ReverseMap();
            CreateMap<PageResult<Specialty>, PageResult<SpecialtyDto>>().ReverseMap();
        }
        private void IndicatorMapperProfile()
        {
            CreateMap<Indicator, IndicatorDto>()
             .ReverseMap();
            CreateMap<PageResult<Indicator>, PageResult<IndicatorDto>>().ReverseMap();
        }
        private void ClientTestMapperProfile()
        {
            CreateMap<ClientTest, ClientTestDto>()
             .ForMember(destination => destination.TestName, src => src.MapFrom(a => a.Test == null ? string.Empty : a.Test.NameOt))
             .ReverseMap();
            CreateMap<PageResult<ClientTest>, PageResult<ClientTestDto>>().ReverseMap();
        }
        private void ClientIndicatorMapperProfile()
        {
            CreateMap<ClientIndicator, ClientIndicatorDto>()
             .ForMember(destination => destination.IndicatorName, src => src.MapFrom(a => a.Indicator == null ? string.Empty : a.Indicator.NameOt))
             .ReverseMap();
            CreateMap<PageResult<ClientIndicator>, PageResult<ClientIndicatorDto>>().ReverseMap();
        }
        private void ClientInsuranceMapperProfile()
        {
            CreateMap<ClientInsurance, ClientInsuranceDto>()
             .ForMember(destination => destination.InsuranceCompanyName, src => src.MapFrom(a => a.InsuranceCompany == null ? string.Empty : a.InsuranceCompany.NameOt))
             .ReverseMap();
            CreateMap<PageResult<ClientInsurance>, PageResult<ClientInsuranceDto>>().ReverseMap();
        }
        private void UserRoleMapperProfile()
        {
            CreateMap<UserRole, UserRoleDto>()
             .ForMember(dest => dest.UserName, src => src.MapFrom(a => a.User == null ? string.Empty : a.User.FullName))
             .ForMember(dest => dest.RoleName, src => src.MapFrom(a => a.Role == null ? string.Empty : a.Role.NameAr))
             .ReverseMap();
            CreateMap<PageResult<UserRole>, PageResult<UserRoleDto>>().ReverseMap();
        }

        private void RolePrivilegeMapperProfile()
        {
            CreateMap<RolePrivilege, RolePrivilegeDto>()
          .ForMember(dest => dest.PrivilegeName, src => src.MapFrom(a => a.Privilege == null ? string.Empty : a.Privilege.PrivilegeName))
          .ForMember(dest => dest.RoleName, src => src.MapFrom(a => a.Role == null ? string.Empty : a.Role.NameAr))
          .ReverseMap();
            CreateMap<PageResult<RolePrivilege>, PageResult<RolePrivilegeDto>>()
                .ReverseMap();
        }

        private void ReportParameterMapperProfile()
        {
            CreateMap<ReportParameter, ReportParameterDto>().ReverseMap();
            CreateMap<PageResult<ReportParameter>, PageResult<ReportParameterDto>>().ReverseMap();
        }

        private void ReportMapperProfile()
        {
            CreateMap<Report, ReportDto>().ReverseMap();
            CreateMap<PageResult<Report>, PageResult<ReportDto>>().ReverseMap();
        }

        private void PrivilegedMapperProfile()
        {
            CreateMap<Privilege, PrivilegeDto>()
             .ForMember(dest => dest.ParentName, src => src.MapFrom(a => a.Parent == null ? string.Empty : a.Parent.PrivilegeName))
            .ReverseMap();
            CreateMap<PageResult<Privilege>, PageResult<PrivilegeDto>>().ReverseMap();
        }

        private void RoleMapperProfile()
        {
            CreateMap<Role, RoleDto>().ReverseMap();
            CreateMap<PageResult<Role>, PageResult<RoleDto>>().ReverseMap();
        }

        private void SettingMapperProfile()
        {
            CreateMap<Setting, SettingDto>().ReverseMap();
            CreateMap<PageResult<Setting>, PageResult<SettingDto>>().ReverseMap();
        }

        private void UserMapperProfile()
        {
            CreateMap<Users, UsersDto>().ReverseMap();
            CreateMap<PageResult<Users>, PageResult<UsersDto>>().ReverseMap();
        }

        private void ClientMapperProfile()
        {
            CreateMap<Client, ClientDto>().ReverseMap();
            CreateMap<PageResult<Client>, PageResult<ClientDto>>().ReverseMap();
        }
        private void ClientFileMapperProfile()
        {
            CreateMap<ClientFile, ClientFileDto>().ReverseMap();
            CreateMap<PageResult<ClientFile>, PageResult<ClientFileDto>>().ReverseMap();
        }
        private void CityMapperProfile()
        {
            CreateMap<City, CityDto>().ForMember(a => a.CountryName, src => src.MapFrom(a => a.Country != null ? a.Country.NameOt : string.Empty)).ReverseMap();
            CreateMap<PageResult<City>, PageResult<CityDto>>().ReverseMap();
        }
        public TDestination Map<TSource, TDestination>(TSource source) => _mapper.Map<TSource, TDestination>(source);

        public void Map<TSource, TDestination>(TSource source, TDestination destination) => Map(source, destination);

        public TDestination Map<TDestination>(object source) => _mapper.Map<TDestination>(source);
    }
}
