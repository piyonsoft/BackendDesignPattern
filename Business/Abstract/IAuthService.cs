using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity.Concrete;
using Core.Utilities.Result;
using Core.Utilities.Security.Jwt;
using Entity.Dto;

namespace Business.Abstract
{
   public interface IAuthService
   {
       IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
       IDataResult<User> Login(UserForLoginDto userForLoginDto);
       IResult UserExist(string email);
       IDataResult<AccessToken> CreateAccessToken(User user);

   }
}
