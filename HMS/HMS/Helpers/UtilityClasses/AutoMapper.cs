using AutoMapper;
using HMS.BusinessPattern.BusinessLogic.BusinessClasses;
using HMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.BusinessPattern.BusinessLogic.UtilityClasses
{
    public static class HMSAutoMapper
    {
        public static IMapper mapper = null;
        static HMSAutoMapper()
        {
            var config = new MapperConfiguration(cfg => {
                ConfigureUserBALToUserModel(cfg);
                ConfigureUserModelToUserBAL(cfg);
                ConfigureCompanyBALToModel(cfg);
                ConfigureCompantModelToBAL(cfg);
                ConfigureBedTypeBALToModel(cfg);
                ConfigureBedTypeModelToBAL(cfg);
                ConfigureRoomTypeBALToModel(cfg);
                ConfigureRoomTypeModelToBAL(cfg);


            });

            mapper = new Mapper(config);
        }
        private static void ConfigureUserBALToUserModel(IMapperConfigurationExpression x)
        {
            x.CreateMap<UserBAL, UserModel>();
        }

        private static void ConfigureUserModelToUserBAL(IMapperConfigurationExpression x)
        {
            x.CreateMap<UserModel, UserBAL>()
           .AfterMap((s, d) =>
           {
               d.UniqueID = GetGUID();
           });
        }

        private static void ConfigureCompanyBALToModel(IMapperConfigurationExpression x)
        {
            x.CreateMap<CompanyBAL, CompanyModel>();
        }

        private static void ConfigureCompantModelToBAL(IMapperConfigurationExpression x)
        {
            x.CreateMap<CompanyModel, CompanyBAL>()
           .AfterMap((s, d) =>
           {
               d.UniqueID = GetGUID();
           });
        }
        private static void ConfigureBedTypeBALToModel(IMapperConfigurationExpression x)
        {
            x.CreateMap<BedTypeBAL, BedTypeModel>();
        }

        private static void ConfigureBedTypeModelToBAL(IMapperConfigurationExpression x)
        {
            x.CreateMap<BedTypeModel, BedTypeBAL>()
           .AfterMap((s, d) =>
           {
               d.UniqueID = GetGUID();
           });
        }

        private static void ConfigureRoomTypeBALToModel(IMapperConfigurationExpression x)
        {
            x.CreateMap<RoomTypeBAL, RoomTypeModel>();
        }

        private static void ConfigureRoomTypeModelToBAL(IMapperConfigurationExpression x)
        {
            x.CreateMap<RoomTypeModel, RoomTypeBAL>()
           .AfterMap((s, d) =>
           {
               d.UniqueID = GetGUID();
           });
        }

        public static string GetGUID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
