using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public  class ExperienceManager:IExperienceService
	{
		IExperienceDal _experienceDal;

		public ExperienceManager(IExperienceDal experienceDal)
		{
			_experienceDal = experienceDal;
		}

		public List<Experience> Getlist()
		{
			return _experienceDal.GetList();
		}

		public void TAdd(Experience t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Experience t)
		{
			throw new NotImplementedException();
		}

		public Experience TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Experience t)
		{
			throw new NotImplementedException();
		}
	}
}
