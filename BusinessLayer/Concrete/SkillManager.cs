﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class SkillManager :ISkillService
	{
		ISkillDal _skillDal;

		public SkillManager(ISkillDal skillDal)
		{
			_skillDal = skillDal;
		}

		public List<Skill> Getlist()
		{
		return _skillDal.GetList();
		}

		public void TAdd(Skill t)
		{
			_skillDal.Insert(t);
		}

		public void TDelete(Skill t)
		{
			_skillDal.Delete(t);
		}

		public List<Skill> TGetbyFilter()
		{
			throw new NotImplementedException();
		}

		public Skill TGetByID(int id)
		{
			return _skillDal.GetByID(id);
		}

		public void TUpdate(Skill t)
		{
			_skillDal.Update(t);
		}
	}
}
