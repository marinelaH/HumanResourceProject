using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Concrete;
using DAL.Contracts;
using Lamar;

namespace DAL.DI
{
    public class RepositoryRegistry : ServiceRegistry
    {
        public RepositoryRegistry()
        {
            IncludeRegistry<UnitOfWorkRegistry>();

            For<IUserRepository>().Use<UserRepository>();

            For<IAftesiRepository>().Use<AftesiRepository>();

            For<ICertifikateRepository>().Use<CertifikateRepository>();
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
>>>>>>> f7b8b08cab4c63435f5c5ec0989881c3b5f88809

            For<IDetajeUserRepository>().Use<DetajeUserRepository>();

            For<IDokumentaDetajeUserRepository>().Use<DokumentaDetajeUserRepository>();

            For<IEdukimRepository>().Use<EdukimRepository>();

            For<ILejeRepository>().Use<LejeRepository>();

            For<IPervojPuneRepository>().Use<PervojPuneRepository>();

            For<IProjektRepository>().Use<ProjektRepository>();

            For<IRoliRepository>().Use<RoliRepository>();

            For<IUserAftesiRepository>().Use<UserAftesiRepository>();

            For<IUserCertifikateRepository>().Use<UserCertifikateRepository>();

            For<IUserEdukimRepository>().Use<UserEdukimRepository>();

            For<IUserPervojePuneRepository>().Use<UserPervojePuneRepository>();

            For<IUserProjektRepository>().Use<UserProjektRepository>();

            For<IUserRoliRepository>().Use<UserRoliRepository>();
<<<<<<< HEAD

=======
>>>>>>> origin/master
>>>>>>> f7b8b08cab4c63435f5c5ec0989881c3b5f88809
        }


    }
}
