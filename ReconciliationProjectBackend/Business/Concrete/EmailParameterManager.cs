using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmailParameterManager : IEmailParameterService
    {
        private readonly IEmailParameterDal _mailParameterDal;

        public EmailParameterManager(IEmailParameterDal mailParameterDal)
        {
            _mailParameterDal = mailParameterDal;
        }
    }
}
