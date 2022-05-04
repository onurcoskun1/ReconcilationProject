using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    /// <summary>
    /// Kullanıcı yetkisini,
    /// Transcaption,
    /// Log,
    /// Validation işlemlerini kontrol eder ve yapar.
    /// </summary>
    public class CompanyManager : ICompanyService
    {
        private readonly ICompanyDal _companyDal;
        public CompanyManager(ICompanyDal companyDal) //Bu Constractor sayesinde new'leme işlemini yapar.
        {
            _companyDal = companyDal;
        }

        public IResult Add(Company company)
        {
            _companyDal.Add(company);
            return new SuccessResult(Messages.AddedCompany);
        }

        public IDataResult<List<Company>> GetAll()
        {
            return new SuccessDataResult<List<Company>>(_companyDal.GetAll(),"Listeleme işlemi tamamlandı!");
        }
    }
}
