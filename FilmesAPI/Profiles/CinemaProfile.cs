using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles;

public class CinemaProfile: Profile
{
    public CinemaProfile()
    {
        CreateMap<CreateCinemaDto, Cinema>();
        CreateMap<UpdateCinemaDto, Cinema>();
        CreateMap<Cinema, ReadCinemaDto>().ForMember(cinemaDto => cinemaDto.EnderecoDto,
            opt => opt.MapFrom(cinema =>cinema.Endereco))
            .ForMember(cinemaDto => cinemaDto.Sessoes,
            opt => opt.MapFrom(cinema => cinema.Sessoes));
    }
}
