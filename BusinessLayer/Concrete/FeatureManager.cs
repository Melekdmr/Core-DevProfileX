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
	public class FeatureManager : IFeatureService
	{
		IFeatureDal _featureDal;

		public FeatureManager(IFeatureDal featureDal)
		{
			_featureDal = featureDal;
		}

		public List<Feature> Getlist()
		{
			return _featureDal.GetList();
		}

		public void TAdd(Feature t)
		{
			_featureDal.Insert(t);
		}

		public void TDelete(Feature t)
		{
			_featureDal.Delete(t);
		}

		public List<Feature> TGetbyFilter()
		{
			throw new NotImplementedException();
		}

		public Feature TGetByID(int id)
		{
			return _featureDal.GetByID(id);
		}

		public void TUpdate(Feature t)
		{
			_featureDal.Update(t);
		}
	}
}
