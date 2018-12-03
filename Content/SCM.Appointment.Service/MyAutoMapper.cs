using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Quantum.FrameworkNetCore.DB.MapperEx;


namespace SCM.Appointment.Service
{
    /// <summary>
    /// 映射类
    /// </summary>
    public class MyAutoMapper : AutoMapperTool
    {
        /// <summary>
        /// 配置
        /// </summary>
        /// <returns></returns>
        public override List<Profile> GetProfiles()
        {
            var profiles = new List<Profile>
            {
                new AutoMapperProfile()
            };
            return profiles;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public static void Init()
        {
            new MyAutoMapper().RegisterMap();
        }
    }

    /// <summary>
    /// 配置信息
    /// </summary>
    public class AutoMapperProfile : Profile
    {
        /// <summary>
        /// 构造
        /// </summary>
        public AutoMapperProfile()
        {
            //this.CreateMap<UiConfigDto, UdfSetQueryDetail>()
            //    .ForMember(x => x.IsForzen, opt => opt.ResolveUsing(x => x.IsFixed));
        }
    }
}