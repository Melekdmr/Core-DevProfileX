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
	public class UserMessageManager:IUserMessageService
	{
		IUserMessageDal _IUserMessageDal;

		public UserMessageManager(IUserMessageDal ıUserMessageDal)
		{
			_IUserMessageDal = ıUserMessageDal;
		}

		public List<UserMessage> Getlist()
		{
			return _IUserMessageDal.GetList();
		}

		public List<UserMessage> GetUserMessageWithUserService()
		{
			return _IUserMessageDal.GetUserMessageWithUser();
		}

		public void TAdd(UserMessage t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(UserMessage t)
		{
			throw new NotImplementedException();
		}

		public List<UserMessage> TGetbyFilter()
		{
			throw new NotImplementedException();
		}

		public UserMessage TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(UserMessage t)
		{
			throw new NotImplementedException();
		}
	}
}
