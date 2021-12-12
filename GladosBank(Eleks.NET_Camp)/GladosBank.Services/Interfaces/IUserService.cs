﻿using GladosBank.Domain;
using System.Collections.Generic;

namespace GladosBank.Services
{
    public interface IUserService
    {
        int BlockUnblockUser(int userId);
        bool CheckWhetherSuchUserExist(User user);
        int CreateUser(User user, string role);
        int DeleteUser(int userId);
        IEnumerable<User> GetAllUsers();
        IEnumerable<User> GetPaginatedUsersList(int pageIndex, int pageSize);
        string GetRole(string login);
        User GetUserByLogin(string Login);
        bool IsActive(string login);
        bool IsSuchLoginInDatabase(string login);
        void SetRoleToSpecifiedUser(User user, string role);
        bool SuchLoginExistOf(string login);
        int UpdateUser(int UserId, string previosLogin, User user);
    }
}