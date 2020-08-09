using AutoMapper;
using HMS.BusinessPattern.BusinessLogic.BusinessClasses;
using HMS.Repository.EMDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.BusinessPattern.BusinessLogic.UtilityClasses
{
    class BPAutoMapper
    {
        public static IMapper mapper = null;
        static BPAutoMapper()
        {
            var config = new MapperConfiguration(cfg => {
                ConfigureUserDALUserBAL(cfg);
                ConfigureUserBALUserDAL(cfg);
                ConfigureCompanyDALcompanyBAL(cfg);
                ConfigureCompnayBALCompnayDAL(cfg);
                ConfigureRoomTypeDALtoBAL(cfg);
                ConfigureRoomTypeBALtoDAL(cfg);
                ConfigureBedTypeDALtoBAL(cfg);
                ConfigureBedTypeBALtoDAL(cfg);
            });

            mapper = new Mapper(config);
        }
        private static void ConfigureUserDALUserBAL(IMapperConfigurationExpression x)
        {
            x.CreateMap<UserMaster, UserBAL>();
        }
        private static void ConfigureUserBALUserDAL(IMapperConfigurationExpression x)
        {
            x.CreateMap<UserBAL, UserMaster> ();
        }
        private static void ConfigureCompanyDALcompanyBAL(IMapperConfigurationExpression x)
        {
            x.CreateMap<CompanyMaster, CompanyBAL>();
        }
        private static void ConfigureCompnayBALCompnayDAL(IMapperConfigurationExpression x)
        {
            x.CreateMap<CompanyBAL, CompanyMaster>();
        }
        private static void ConfigureRoomTypeDALtoBAL(IMapperConfigurationExpression x)
        {
            x.CreateMap<RoomTypeMaster, RoomTypeBAL>();
        }
        private static void ConfigureRoomTypeBALtoDAL(IMapperConfigurationExpression x)
        {
            x.CreateMap<RoomTypeBAL, RoomTypeMaster>();
        }
        private static void ConfigureBedTypeDALtoBAL(IMapperConfigurationExpression x)
        {
            x.CreateMap<BedTypeMaster, BedTypeBAL>();
        }
        private static void ConfigureBedTypeBALtoDAL(IMapperConfigurationExpression x)
        {
            x.CreateMap<BedTypeBAL, BedTypeMaster>();
        }

    }
}
