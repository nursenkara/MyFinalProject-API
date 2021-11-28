using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
       // IServiceCollection ı genişletmeye çalışıyoruz polimorfizm yapacağız icoremodule ı alan coremodule ve başka classları da kabul
       //etsin diye genişletme yapıyoruz.neyi genişletmek istiyorsan onu this ile veriyorsunuz parametre demek değil,--> c#ta this ile
       //verilir bu şekilde yazılır
       //parametreyi sonra veriyorsun
       //extensions classları her zaman statik verilir
       //ekleyeceğimiz bütün injectionları toplamak için bunu yazdık,biz başka modüller de ekleyebilirdik
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection serviceCollection,ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(serviceCollection);
            }
            return ServiceTool.Create(serviceCollection);
        }
    }
}
