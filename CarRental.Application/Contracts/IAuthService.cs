using CarRental.Data.Abstracts;
using CarRental.Data.DTO.Requests;
using CarRental.Data.Models.Entities;
using System.IdentityModel.Tokens.Jwt;

namespace CarRental.Application.Contracts
{
    public interface IAuthService
    {
        Task<IDataResult<User>> Register(UserRegistarDTO userForRegisterDto);
        Task<IDataResult<User>> Login(UserLoginReq userForLoginDto);
        Task<IResult> UserExists(string email);
        Task<string> GenerateToken(User user);
        Task<IResult> ChangePassword(ChangePasswordDTO changePasswordDto);
        Task<IResult> ConfirmEmailAddress(ConfirmEmailDTO data);
        Task<IResult> ResetPassword(string email);
        Task<IResult> ResetPassword(ResetPasswordRequest data);

        //IResult UserDetailUpdate(UserDetailForUpdate userDetailForUpdate);
    }

}
