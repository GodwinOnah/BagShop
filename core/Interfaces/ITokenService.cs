using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entities.Identity;

namespace core.Interfaces
{
    public interface ITokenService
    {
        string createToken(User user);
    }
}