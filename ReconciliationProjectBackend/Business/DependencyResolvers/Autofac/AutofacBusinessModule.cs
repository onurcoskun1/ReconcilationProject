using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    /// <summary>
    /// Burada;
    /// -Service ile Manager'ı,
    /// -ICompanyDal ile de EFCompanyDal'ı eşleştireceğiz
    /// </summary>
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CompanyManager>().As<ICompanyService>(); 
            builder.RegisterType<EFCompanyDal>().As<ICompanyDal>();

            builder.RegisterType<AccountReconciliationManager>().As<IAccountReconciliationService>();
            builder.RegisterType<EFAccountReconciliationDal>().As<IAccountReconciliationDal>();

            builder.RegisterType<AccountReconciliationDetailManager>().As<IAccountReconciliationDetailService>();
            builder.RegisterType<EFAccountReconciliationDetailDal>().As<IAccountReconciliationDetailDal>();

            builder.RegisterType<BaBsReconciliationManager>().As<IBaBsReconciliationService>();
            builder.RegisterType<EFBaBsReconciliationDal>().As<IBaBsReconciliationDal>();

            builder.RegisterType<CurrencyAccountManager>().As<ICurrencyAccountService>();
            builder.RegisterType<EFCurrencyAccountDal>().As<ICurrencyAccountDal>();

            builder.RegisterType<CurrencyManager>().As<ICurrencyService>();
            builder.RegisterType<EFCurrencyDal>().As<ICurrencyDal>();

            builder.RegisterType<EmailParameterManager>().As<IEmailParameterService>();
            builder.RegisterType<EFEmailParameterDal>().As<IEmailParameterDal>();
        }
    }
}
