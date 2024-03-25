using API_StoresWeb.Models;
using API_StoresWeb.Services;
using Microsoft.AspNetCore.Identity;
using System.Collections.Immutable;
using System.Xml.Linq;

namespace API_StoresWeb.Repositories
{
    public class UsersRepos : IUsers
    {
        List<UsersModel> IUsers.findAllUsers()
        {
            List<UsersModel> listUsers = new List<UsersModel>()
            {
                new UsersModel()
                {
                    ID = Guid.NewGuid(),
                    Code = "UserCode0",
                    Name  = "Trần Quốc Toàn 0",
                    Email = "tranquoctoan0@gmail.com",
                    Password = "Admin@123",
                    Username = "TQT0",
                    PasswordHash = "",
                    HasPassword = true,
                    HasEmail = true,
                    Address = "Phú thứ, Quận Cái Răng",
                    City  = "Cần Thơ",
                    Region  = "VN",
                    PostalCode  = "900000",
                    Country = "Việt Nam",
                    Phone = "0123456789",
                    Gender = (int?)CommonData.CommonData.Gender.Male,
                    AvtImage = "images/avt0.png"
                },
                new UsersModel()
                {
                    ID = Guid.NewGuid(),
                    Code = "UserCode1",
                    Name  = "Nguyễn Thị Thuý Liễu",
                    Email = "nguyenthithuylieu0@gmail.com",
                    Password = "Admin@123",
                    Username = "NTTL0",
                    PasswordHash = "",
                    HasPassword = true,
                    HasEmail = true,
                    Address = "Phú thứ, Quận Cái Răng",
                    City  = "Cần Thơ",
                    Region  = "VN",
                    PostalCode  = "900000",
                    Country = "Việt Nam",
                    Phone = "0123456780",
                    Gender = (int?)CommonData.CommonData.Gender.Female,
                    AvtImage = "images/avt1.png"
                },
                new UsersModel()
                {
                    ID = Guid.NewGuid(),
                    Code = "UserCode2",
                    Name  = "Lâm Thị Bảo",
                    Email = "lamthibao@gmail.com",
                    Password = "Admin@123",
                    Username = "LTB",
                    PasswordHash = "",
                    HasPassword = true,
                    HasEmail = true,
                    Address = "Phú thứ, Quận Cái Răng",
                    City  = "Cần Thơ",
                    Region  = "VN",
                    PostalCode  = "900000",
                    Country = "Việt Nam",
                    Phone = "0123456781",
                    Gender = (int?)CommonData.CommonData.Gender.Other,
                    AvtImage = "images/avt2.png"
                },
            };
            return listUsers;
        }

        UsersModel IUsers.findUserByCode(string Code)
        {
            throw new NotImplementedException();
        }

        UsersModel IUsers.findUserByID(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
