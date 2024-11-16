﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Interfaces
{
    public interface ITeacher
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        string GetInfo();
    }

}
