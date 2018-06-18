using Authentication.API.Data;
using System.Threading.Tasks;

namespace  Authentication.API.Services
{
    public interface IDbInitializer
    {
        Task Initialize(ApplicationDbContext context);
    }
}
