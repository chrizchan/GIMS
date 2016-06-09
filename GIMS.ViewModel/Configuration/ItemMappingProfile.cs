using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using GIMS.ViewModel.Item;


namespace GIMS.ViewModel.Configuration
{
    public class ItemMappingProfile : Profile
    {
        protected override void Configure()
        {
            //Mapper.CreateMap<ItemRCInformation, ItemViewModel>()
            //   .ForMember(dest => dest.ShortItemNo,
            //       opt => opt.MapFrom(src => src.ShortItemNo))
            //   .ForMember(dest => dest.ItemNo2nd,
            //       opt => opt.MapFrom(src => src.ItemNo2nd));

            //Mapper.CreateMap<Entities.Item, ItemSearchListViewModel>()
            //   .ForMember(dest => dest.ShortItemNo,
            //       opt => opt.MapFrom(src => src.ShortItemNo))
            //   .ForMember(dest => dest.ItemNo2nd,
            //       opt => opt.MapFrom(src => src.ItemNo2nd));

        }
    }
}
