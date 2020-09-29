using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CarInfo.Data.Models
{
    public class CustomUserValidator : IUserValidator<User>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<User> manager, User user)
        {
            List<IdentityError> errors = new List<IdentityError>();

            if (user.Email.ToLower().EndsWith("@spam.com"))
            {
                errors.Add(new IdentityError
                {
                    Description = "This domain is in the spam database. Choose another mail service"
                });
            }
            if (user.UserName.Contains("admin"))
            {
                errors.Add(new IdentityError
                {
                    Description = "User nickname should not contain the word 'admin'"
                });
            }
            return Task.FromResult(errors.Count == 0 ?
                IdentityResult.Success : IdentityResult.Failed(errors.ToArray()));
        }
    }
}