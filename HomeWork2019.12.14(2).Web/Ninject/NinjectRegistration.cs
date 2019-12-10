using HomeWork2019._12._14_2_.AbstractModels;
using HomeWork2019._12._14_2_.DataAccess;
using HomeWork2019._12._14_2_.Models;
using HomeWork2019._12._14_2_.Services;
using Ninject.Modules;

namespace HomeWork2019._12._14_2_.Web.Ninject
{
    public class NinjectRegistration : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IRepository<User>>().To<DbRepository<User>>().WithConstructorArgument("context", new InstagramContext());
            this.Bind<IRepository<Post>>().To<DbRepository<Post>>().WithConstructorArgument("context", new InstagramContext());
        }
    }
}