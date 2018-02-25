using System;

namespace VastGIS.Shared
{
    public interface IEnumConverter<T> where T : IConvertible
    {
        string GetString(T value);
    }
}
