using AutoMapper;
using imrp.application.Interfaces;

namespace imrp.persistence.Mappers;

public class MapperService<TSource, TDestination> (IMapper mapper) : IMapperService<TSource, TDestination>
{
    private readonly IMapper _mapper = mapper;

    public TDestination Map(TSource source)
    {
        return _mapper.Map<TDestination>(source);
    }

    public TSource MapBack(TDestination destination)
    {
        return _mapper.Map<TSource>(destination);
    }
}