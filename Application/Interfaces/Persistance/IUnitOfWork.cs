﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Persistance
{
    public interface IUnitOfWork
    {
        void Save();
    }
}
