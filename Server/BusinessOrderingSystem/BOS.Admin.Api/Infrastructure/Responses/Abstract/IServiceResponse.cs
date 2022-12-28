using BOS.Admin.Api.Infrastructure.Responses.ComplexTypes;

namespace BOS.Admin.Api.Infrastructure.Responses.Abstract
{
    public interface IServiceResponse
    {
        ResponseCode ResponseCode { get; }
        string Message { get; }
    }
}
