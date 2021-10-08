using WebStore.ViewModels;

namespace WebStore.Sevices.Interfaces
{
    public interface ICartService
    {
        void Add(int Id);

        void Decriment(int Id);

        void Remove(int Id);

        void Clear();

        CartViewModel GetViewModel();
    }
}
