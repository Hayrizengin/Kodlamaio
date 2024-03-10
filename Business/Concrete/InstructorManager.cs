using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _ınstructorDal;

        public InstructorManager(IInstructorDal ınstructorDal)
        {
            _ınstructorDal = ınstructorDal;
        }

        public void Add(Instructor ınstructor)
        {
            _ınstructorDal.Add(ınstructor);
        }

        public void Delete(Instructor ınstructor)
        {
            _ınstructorDal.Delete(ınstructor);

        }

        public List<Instructor> GetAll()
        {
            return _ınstructorDal.GetAll();
        }

        public Instructor GetById(int id)
        {
            return _ınstructorDal.Get(ı=>ı.InstructorId==id);
        }

        public void Update(Instructor ınstructor)
        {
            _ınstructorDal.Update(ınstructor);

        }
    }
}
