using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);
        object Get(string key);
        void Add(string key,object value,int duration);
        bool IsAdd(string key);//cache de varmı yoksa al gel cacheye de ekle
        void Remove(string key);

        void RemoveByPattern(string pattern);


    }
}
