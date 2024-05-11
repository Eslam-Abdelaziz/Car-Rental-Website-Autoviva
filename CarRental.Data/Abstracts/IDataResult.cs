

namespace CarRental.Data.Abstracts
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
