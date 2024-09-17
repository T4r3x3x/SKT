using System.Threading.Tasks;

namespace SKT.Services.FileService
{
    public interface IFileDialogService
    {
        Task Save();
        Task Load();
    }
}