﻿using EcoEspresso.Domain.Commons;

namespace EcoEspresso.Domain.Entities;

public class Admin : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string PasswordHash { get; set; }
    public string Salt { get; set; }
}
