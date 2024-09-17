using Avalonia;

using SKT.Extensions;

using System.IO;
using System.Threading.Tasks;

namespace SKT.Services.FileService
{
    public class FileDialogService : IFileDialogService
    {
        public async Task Save()
        {
            var mainWindow = Application.Current!.GetMainWindow();

            var file = await mainWindow.StorageProvider.SaveFilePickerAsync(new()
            {
                Title = "Save Text File"
            });

            if (file is null)
                return;

            await using var stream = await file.OpenWriteAsync();
            await using var streamWriter = new StreamWriter(stream);
            await streamWriter.WriteLineAsync("Hello World!");
        }

        public async Task Load()
        {
            var mainWindow = Application.Current!.GetMainWindow();

            var files = await mainWindow.StorageProvider.OpenFilePickerAsync(new()
            {
                Title = "Open Text File",
                AllowMultiple = false
            });

            if (files.Count < 1)
                return;

            await using var stream = await files[0].OpenReadAsync();
            using var streamReader = new StreamReader(stream);
            var fileContent = await streamReader.ReadToEndAsync();
        }
    }
}