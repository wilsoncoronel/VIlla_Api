﻿using AutoMapper;
using MagicVillaAPI.Modelos;
using MagicVillaAPI.Modelos.Dto;

namespace MagicVillaAPI
{
    public class MappingConfig: Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDto>().ReverseMap();
            CreateMap<Villa, VillaUpdateDto>().ReverseMap();
            CreateMap<Villa, VillaCreateDto>().ReverseMap();
        }
    }
}
