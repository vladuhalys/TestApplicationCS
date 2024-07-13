using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class UserDTO : IUserDTO
    {
        int IUserDTO.Id { set; get; }
        string? IUserDTO.Name { set; get; }
        string? IUserDTO.Email { set; get; }
        string? IUserDTO.Password { set; get; }
    }
}
