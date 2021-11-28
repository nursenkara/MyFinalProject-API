using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);//generic
        // object Get(string key); type casting gerekir
        object Get(string key);
        void Add(string key, object value, int duration);
        bool IsAdd(string key);//cache te var mı? kontrolü
        void Remove(string key);
        void RemoveByPattern(string pattern);
    }
}
