using Microsoft.AspNetCore.Http;
using WebStore.Sevices.Interfaces;
using WebStore.ViewModels;

namespace WebStore.Sevices.InCookies
{
    public class InCookiesCartService : ICartService
    {
        private readonly IHttpContextAccessor _HttpContextAccessor;
        private readonly IProductData _ProductData;
        private readonly string _CartName;

        public InCookiesCartService(IHttpContextAccessor HttpContextAccessor, IProductData ProductData)
        {
            _HttpContextAccessor = HttpContextAccessor;
            _ProductData = ProductData;

            var user = HttpContextAccessor.HttpContext!.User;
            var user_name = user.Identity!.IsAuthenticated ? $"-{user.Identity.Name}" : null;

            _CartName = $"WebStore.Cart{user_name}";
        }
        
        public void Add(int Id) { throw new System.NotImplementedException(); }

        public void Decriment(int Id) { throw new System.NotImplementedException(); }

        public void Remove(int Id) { throw new System.NotImplementedException(); }

        public void Clear() { throw new System.NotImplementedException(); }

        public CartViewModel GetViewModel() { throw new System.NotImplementedException(); }
    }
}
