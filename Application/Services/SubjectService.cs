using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository _subjectRepository;

        public SubjectService(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        public List<Subject> GetAll()
        {
            return _subjectRepository.GetAll();
        }

        public Subject Create(Subject subject)
        {
            var obj = new Subject(subject.Name);
            return _subjectRepository.Add(obj);
        }
    }
}
