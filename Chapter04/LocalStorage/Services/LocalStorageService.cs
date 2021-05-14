using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace LocalStorage.Services
{
    public class LocalStorageService : ILocalStorageService
    {
        private IJSRuntime js;
        public LocalStorageService(IJSRuntime JsRuntime)
        {
            js = JsRuntime;
        }

        public async Task<T> GetItemAsync<T>(string key)
        {
            var json = await js.InvokeAsync<string>("bweInterop.getLocalStorage", key);

            return string.IsNullOrEmpty(json)
                    ? default
                    : JsonSerializer.Deserialize<T>(json);
        }

        public async Task SetItemAsync<T>(string key, T item)
        {
            await js.InvokeVoidAsync("bweInterop.setLocalStorage", key, JsonSerializer.Serialize(item));
        }
    }
}
