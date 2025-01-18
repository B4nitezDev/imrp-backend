namespace imrp.application.Interfaces;

public interface IMapperService<TSource, TDestination>
{
    TDestination Map(TSource source);
    TSource MapBack(TDestination destination);
}