using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalStorage.Services
{
    interface ILocalStorageService
    {
        Task SetItemAsync<T>(string key, T item);
        Task<T> GetItemAsync<T>(string key);

    }
}
