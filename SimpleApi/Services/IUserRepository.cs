﻿using SimpleApi.Models;

namespace SimpleApi.Services;

// Abstract Product Interface
public interface IUserRepository
{
    void Save(User user);
    User GetById(int userId);
}