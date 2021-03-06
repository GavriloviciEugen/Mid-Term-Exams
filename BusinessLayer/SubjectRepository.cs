﻿using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class SubjectRepository : IRepository<Subject>
    {
        private readonly SubjectsContext _context;

        public SubjectRepository(SubjectsContext context)
        {
            _context = context;
            _context = context;
        }

        public void Create(Subject subject)
        {
            _context.Add(subject);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var Subject = _context.Set<Subject>().FirstOrDefault(e => e.Id == id);
            _context.Remove(Subject);
            _context.SaveChanges();
        }

        public List<Subject> GetAll()
        {
            return _context.Set<Subject>().ToList();
        }

        public Subject GetById(Guid id)
        {
            return _context.Set<Subject>().FirstOrDefault(e => e.Id == id);
        }

        public void Update(Subject subject)
        {
            _context.Update(subject);
            _context.SaveChanges();
        }
    }
}