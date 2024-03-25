using API_StoresWeb.Data;
using API_StoresWeb.Models;
using API_StoresWeb.Repositories;
using API_StoresWeb.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static API_StoresWeb.CommonData.CommonData;
using System.Diagnostics.Metrics;
using System.Net;
using System.Numerics;
using System.Xml.Linq;

namespace API_StoresWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly StoresWebAPIDbContact dbContact;

        public UsersController(StoresWebAPIDbContact dbContact)
        {
            this.dbContact = dbContact;
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetUserById([FromRoute] Guid id) {
            var user = await dbContact.Users.FindAsync(id);
            if (user != null)
            {
                return Ok(user);
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await dbContact.Users.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(UsersModel usersModel)
        {
            var user = new UsersModel()
            {
                ID = Guid.NewGuid(),
                Code = usersModel.Code,
                Name = usersModel.Name,
                Email = usersModel.Email,
                Password = usersModel.Password,
                Username = usersModel.Username,
                PasswordHash = usersModel.PasswordHash,
                HasPassword = usersModel.HasPassword,
                HasEmail = usersModel.HasEmail,
                Address = usersModel.Address,
                City = usersModel.City,
                Region = usersModel.Region,
                PostalCode = usersModel.PostalCode,
                Country = usersModel.Country,
                Phone = usersModel.Phone,
                Gender = usersModel.Gender,
                AvtImage = usersModel.AvtImage
            };

            await dbContact.Users.AddAsync(user);
            await dbContact.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateUser([FromRoute] Guid id,UsersModel usersModel)
        {
            var user = await dbContact.Users.FindAsync(id);

            if (user != null)
            {
                user.Code = usersModel.Code;
                user.Name = usersModel.Name;
                user.Email = usersModel.Email;
                user.Password = usersModel.Password;
                user.Username = usersModel.Username;
                user.PasswordHash = usersModel.PasswordHash;
                user.HasPassword = usersModel.HasPassword;
                user.HasEmail = usersModel.HasEmail;
                user.Address = usersModel.Address;
                user.City = usersModel.City;
                user.Region = usersModel.Region;
                user.PostalCode = usersModel.PostalCode;
                user.Country = usersModel.Country;
                user.Phone = usersModel.Phone;
                user.Gender = usersModel.Gender;
                user.AvtImage = usersModel.AvtImage;

                await dbContact.SaveChangesAsync();

                return Ok(user);
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteUsers([FromRoute] Guid id)
        {
            var user = await dbContact.Users.FindAsync(id);
            if(user != null)
            {
                dbContact.Remove(user);
                await dbContact.SaveChangesAsync();
                return Ok(user);
            }
            return NotFound(user);
        }
    }
}
