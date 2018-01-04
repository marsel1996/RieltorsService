using RieltorsService.Dto;
using System.ServiceModel;

namespace RieltorsService
{
    [ServiceContract]
    public interface IRieltorsService
    {
        [OperationContract]
        UserDto Authorization(string login,string passwordMD5);
    }
}
