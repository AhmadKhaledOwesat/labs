namespace JoLab.Application.Interfaces
{
    public interface IJoLabMapper
    {
        TDestination Map<TSource , TDestination>(TSource source);
        void Map<TSource, TDestination>(TSource source , TDestination destination);
        TDestination Map<TDestination>(object source);
    }
}
