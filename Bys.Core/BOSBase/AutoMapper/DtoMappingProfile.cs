using AutoMapper;
using BOSERP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSBase.AutoMapper
{
    public class DtoMappingProfile : Profile
    {
        public DtoMappingProfile()
        {
            CreateMap<ICProductsInfo, ICProductsForViewInfo>();
            CreateMap<ICProductsInfo, ICProductsForViewIMES>();

            CreateMap<ICProductsForViewIMES, ICProductsInfo>();
            CreateMap<ICProductsForViewInfo, ICProductsInfo>();
        }
    }
}
