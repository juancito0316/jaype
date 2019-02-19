using Application.Interfaces.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Shared
{
    public class UnitOfWork : IUnitOfWork {

        readonly IDatabaseContext _database;

        public UnitOfWork(IDatabaseContext database) {
            this._database = database;
        }

        public void Save() {
            _database.Save();
        }
    }
}
