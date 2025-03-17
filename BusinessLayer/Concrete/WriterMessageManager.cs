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
	public class WriterMessageManager:IWriterMessageService
	{
		IWriterMessageDal _writerMessageDal;
			
      public WriterMessageManager(IWriterMessageDal writerMessageDal)
		{
			_writerMessageDal = writerMessageDal;
		}

		public List<WriterMessage> Getlist()
		{
			throw new NotImplementedException();
		}

		public void TAdd(WriterMessage t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(WriterMessage t)
		{
			throw new NotImplementedException();
		}

		public List<WriterMessage> TGetbyFilter(string p)
		{
			return _writerMessageDal.GetbyFilter(x => x.Receiver == p);
		}

		public WriterMessage TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(WriterMessage t)
		{
			throw new NotImplementedException();
		}
	}
}
