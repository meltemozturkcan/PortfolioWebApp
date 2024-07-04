using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class ExperianceManager : IExperianceService
    {
        IExperianceDal _experianceDal;

        public ExperianceManager(IExperianceDal experianceDal)
        {
            _experianceDal = experianceDal;
        }

        public Experiance TGetByID(int id)
        {
          return _experianceDal.GetByID(id);
        }

        public void TAdd(Experiance t)
        {
            _experianceDal.Insert(t);
        }

        public void TDelete(Experiance t)
        {
            _experianceDal.Delete(t);
        }

        public List<Experiance> TGetList()
        {
           return _experianceDal.GetList();
        }

        public void TUpdate(Experiance t)
        {
            _experianceDal.Update(t);
        }
    }
}
