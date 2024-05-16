using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ISubjectRepository
    {
        Subject Add(Subject subject);
        void Delete(Subject subject);
        List<Subject> GetAll();        
        Subject GetById(int id);
        void Update(Subject subject);
    }
}
