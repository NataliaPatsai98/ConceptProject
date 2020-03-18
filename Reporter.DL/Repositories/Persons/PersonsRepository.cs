﻿using Reporter.DL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reporter.DL.Repositories.Persons {
    public class PersonsRepository: IRepository<PersonEntity> {
        private ReporterDBContext _dbContext;
        public PersonsRepository(ReporterDBContext dbContext) {
            this._dbContext = dbContext;
        }

        public IEnumerable<PersonEntity> ReadAll() {
            return _dbContext.Persons;
        }

        public void Create(PersonEntity entity) {
            _dbContext.Persons.Add(entity);
        }

        public PersonEntity GetById(int Id) {
            return _dbContext.Persons.Find(Id);
        }

        public void Update(PersonEntity entity) {
            _dbContext.Persons.Update(entity);
        }

        public void Delete(int id) {
            PersonEntity person = _dbContext.Persons.Find(id);
            if (person != null) {
                _dbContext.Persons.Remove(person);
            }
        }
    }

}
