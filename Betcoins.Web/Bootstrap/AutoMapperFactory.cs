using AutoMapper;
using Betcoins.Model.Client;
using Db = Betcoins.DomainClasses.Models;

namespace Betcoins.Web.Bootstrap
{
    public class AutoMapperFactory
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.CreateMap<Db.Account, _Account>().ReverseMap();
            });
        }
    }
}