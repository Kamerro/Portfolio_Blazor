using System.Threading.Tasks;
using ClassWithParameters;
namespace PortfolioBlazor.Interfaces
{
    public interface IProduct
    {
        Task<IEnumerable<Products>> GetProducts();
    }
}
