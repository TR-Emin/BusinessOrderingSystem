using BOS.Admin.Api.Infrastructure.Responses.Abstract;
using BOS.Admin.Api.Infrastructure.Responses.ComplexTypes;

namespace BOS.Admin.Api.Infrastructure.Responses.Concrete
{
    public class ServiceResponse<T> : IServiceResponse
    {
        public ResponseCode ResponseCode { get; }
        public string Message { get; }
        public T? Data { get; }

        public ServiceResponse(ResponseCode responseCode)
        {
            ResponseCode = responseCode;
            Message = responseCode.ToString();
        }

        public ServiceResponse(ResponseCode responseCode, string message)
        {
            ResponseCode = responseCode;
            Message = message;
        }

        public ServiceResponse(ResponseCode responseCode, T data)
        {
            ResponseCode = responseCode;
            Data = data;
            Message = responseCode.ToString();
        }

        public ServiceResponse(ResponseCode responseCode, T data, string message)
        {
            ResponseCode = responseCode;
            Data = data;
            Message = message;
        }
    }

    public class ServiceResponse : IServiceResponse
    {
        public ResponseCode ResponseCode { get; }
        public string Message { get; }

        public ServiceResponse(ResponseCode responseCode)
        {
            ResponseCode = responseCode;
            Message = responseCode.ToString();
        }

        public ServiceResponse(ResponseCode responseCode, string message)
        {
            ResponseCode = responseCode;
            Message = message;
        }

    }
}
