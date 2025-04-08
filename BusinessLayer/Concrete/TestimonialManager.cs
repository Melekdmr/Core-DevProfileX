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
public class TestimonialManager:ITestimonialService
	{
		ITestimonialDal _testimonialDal;

		public TestimonialManager(ITestimonialDal testimonialDal)
		{
			this._testimonialDal = testimonialDal;
		}

		public List<Testimonial> Getlist()
		{
			return _testimonialDal.GetList();
		}

		public void TAdd(Testimonial t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Testimonial t)
		{
			 _testimonialDal.Delete(t);
		}

		public List<Testimonial> TGetbyFilter()
		{
			throw new NotImplementedException();
		}

		public Testimonial TGetByID(int id)
		{
			 return _testimonialDal.GetByID(id);
		}

		public void TUpdate(Testimonial t)
		{
			_testimonialDal.Update(t);
		}
	}
}
