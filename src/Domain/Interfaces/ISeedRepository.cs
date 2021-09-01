using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ISeedRepository
    {
        Task<bool> ResetDataAsync();
    }
}