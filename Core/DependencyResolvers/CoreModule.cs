using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        //servis bağımlılıklarını çözeceğimiz yer.Normalde web apide startupta yapmıştık bunu..net ile ilgili şeyler startupta
        //bunun devrede olması gerekiyor servicetool bizden servisleri istiyor startupı açın.web apinin bundan haberi olması gerekiyor
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache();//.NET CORE UN KENDİSİ OTOMATİK İNJECTİON YAPIYOR
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();

        }
    }
}
