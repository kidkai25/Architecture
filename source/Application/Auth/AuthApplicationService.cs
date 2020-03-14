using Architecture.CrossCutting.Resources;
using Architecture.Database;
using Architecture.Domain;
using Architecture.Model;
using DotNetCore.Extensions;
using DotNetCore.Results;
using DotNetCore.Security;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Architecture.Application
{
    public sealed class AuthApplicationService : IAuthApplicationService
    {
        private readonly IAuthRepository _authRepository;
        private readonly IHashService _hashService;
        private readonly IJsonWebTokenService _jsonWebTokenService;

        public AuthApplicationService
        (
            IAuthRepository authRepository,
            IHashService hashService,
            IJsonWebTokenService jsonWebTokenService
        )
        {
            _authRepository = authRepository;
            _hashService = hashService;
            _jsonWebTokenService = jsonWebTokenService;
        }

        public async Task<IResult<AuthEntity>> AddAsync(AuthModel authModel)
        {
            var validation = await new AuthModelValidator().ValidateAsync(authModel);

            if (validation.Failed)
            {
                return Result<AuthEntity>.Fail(validation.Message);
            }

            if (await _authRepository.AnyByLoginAsync(authModel.Login))
            {
                return Result<AuthEntity>.Fail(Texts.AuthError);
            }

            var authEntity = AuthFactory.Create(authModel);

            var password = _hashService.Create(authEntity.Password, authEntity.Salt);

            authEntity.ChangePassword(password);

            await _authRepository.AddAsync(authEntity);

            return Result<AuthEntity>.Success(authEntity);
        }

        public async Task DeleteAsync(long id)
        {
            await _authRepository.DeleteAsync(id);
        }

        public async Task<IResult<TokenModel>> SignInAsync(SignInModel signInModel)
        {
            var validation = await new SignInModelValidator().ValidateAsync(signInModel);

            if (validation.Failed)
            {
                return Result<TokenModel>.Fail(validation.Message);
            }

            var authEntity = await _authRepository.GetByLoginAsync(signInModel.Login);

            validation = Validate(authEntity, signInModel);

            if (validation.Failed)
            {
                return Result<TokenModel>.Fail(validation.Message);
            }

            var tokenModel = CreateToken(authEntity);

            return Result<TokenModel>.Success(tokenModel);
        }

        private TokenModel CreateToken(AuthEntity authEntity)
        {
            var claims = new List<Claim>();

            claims.AddSub(authEntity.Id.ToString());

            claims.AddRoles(authEntity.Roles.ToArray());

            var token = _jsonWebTokenService.Encode(claims);

            return new TokenModel(token);
        }

        private IResult Validate(AuthEntity authEntity, SignInModel signInModel)
        {
            if (authEntity == default || signInModel == default)
            {
                return Result.Fail(Texts.SignInError);
            }

            var password = _hashService.Create(signInModel.Password, authEntity.Salt);

            if (authEntity.Password != password)
            {
                return Result.Fail(Texts.SignInError);
            }

            return Result.Success();
        }
    }
}
