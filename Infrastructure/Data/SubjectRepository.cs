using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class SubjectRepository : ISubjectRepository
    {
        static int LastIdAssigned = 0;
        static List<Subject> subjects = [];

        public Subject Add(Subject subject)
        {
            subject.Id = ++LastIdAssigned;
            subjects.Add(subject);
            return subject;
        }

        public void Delete(Subject subject)
        {
            subjects.Remove(subject);
        }

        public List<Subject> GetAll()
        {
            return subjects.ToList();
        }

        public Subject GetById(int id) {
            return subjects.FirstOrDefault(subject => subject.Id == id);
        }

        public void Update(Subject subject)
        {
            Subject obj = GetById(subject.Id);

            obj.Name = subject.Name;
        }
    }
}
