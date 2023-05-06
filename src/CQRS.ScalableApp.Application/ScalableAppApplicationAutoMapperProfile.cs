﻿using AutoMapper;
using CQRS.ScalableApp.Models.Players;
using CQRS.ScalableApp.Players.Dtos;

namespace CQRS.ScalableApp;

public class ScalableAppApplicationAutoMapperProfile : Profile
{
    public ScalableAppApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<PlayerDto, Player>().ReverseMap();
       
    }
}
