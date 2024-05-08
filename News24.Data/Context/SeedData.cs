using News24.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace News24.Data.Context;

internal static class SeedData
{
    //IdentitySeed Seed
    public static void IdentitySeed(this ModelBuilder builder)
    {
        string ADMIN_ID = "0f8fad5b-d9cb-469f-a165-70867728950e";
        string ROLE_ID = "7c9e6679-7425-40de-944b-e07fc1f90ae7";
        string ROLE_ID2 = Guid.NewGuid().ToString();
        string ROLE_ID3 = Guid.NewGuid().ToString();

        //seed admin role
        builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Name = StaticDetail.Role_Admin,
                NormalizedName = StaticDetail.Role_Admin.ToUpper(),
                Id = ROLE_ID,
                ConcurrencyStamp = ROLE_ID
            },
             new IdentityRole
             {
                 Name = StaticDetail.Role_Customer,
                 NormalizedName = StaticDetail.Role_Customer.ToUpper(),
                 Id = ROLE_ID2,
                 ConcurrencyStamp = ROLE_ID2
             },
              new IdentityRole
              {
                  Name = StaticDetail.Role_Employee,
                  NormalizedName = StaticDetail.Role_Employee.ToUpper(),
                  Id = ROLE_ID3,
                  ConcurrencyStamp = ROLE_ID3
              }
            );

        //create user
        var appUser = new IdentityUser
        {
            Id = ADMIN_ID,
            UserName = "admin@gmail.com",
            NormalizedUserName = "admin@gmail.com".ToUpper(),
            Email = "admin@gmail.com",
            NormalizedEmail = "admin@gmail.com".ToUpper(),
            EmailConfirmed = true,
        };

        //set user password
        PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
        appUser.PasswordHash = ph.HashPassword(appUser, "Admin123!");

        //seed user
        builder.Entity<IdentityUser>().HasData(appUser);

        //set user role to admin
        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            RoleId = ROLE_ID,
            UserId = ADMIN_ID
        });
    }
}