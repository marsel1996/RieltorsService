using RieltorsService.Dto;

namespace RieltorsService
{
    public class Service1 : IRieltorsService
    {
        public UserDto Authorization(string login, string passwordMD5)
        {
            //запрос
            return new UserDto {
                Login= login,
                PassWord= passwordMD5
            };
        }
    }
}
