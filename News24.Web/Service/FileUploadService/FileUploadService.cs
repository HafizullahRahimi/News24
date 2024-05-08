using Microsoft.AspNetCore.Components.Forms;

namespace News24.Web.Service.FileUploadService;

public class FileUploadService : IFileUploadService
{
    private readonly IWebHostEnvironment _webHostEnvironment;

    public FileUploadService(IWebHostEnvironment webHostEnvironment)
    {
        _webHostEnvironment = webHostEnvironment;
    }

    public async Task<string> UploadFile(IBrowserFile file)
    {
        try
        {
            //FileInfo fileInfo = new FileInfo(file.Name);
            //string fileName = Guid.NewGuid().ToString() + fileInfo.Extension; 
            string fileName = $"{Guid.NewGuid()}-{file.Name}";
            var folderDirectory = $"{_webHostEnvironment.WebRootPath}\\images";
            var path = Path.Combine(_webHostEnvironment.WebRootPath, "images", fileName);

            var memoryStream = new MemoryStream();
            await file.OpenReadStream().CopyToAsync(memoryStream);

            if (!Directory.Exists(folderDirectory))
            {
                Directory.CreateDirectory(folderDirectory);
            }

            await using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                memoryStream.WriteTo(fs);
            }

            return fileName;

        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public bool DeleteFile(string fileName)
    {
        try
        {
            var path = $"{_webHostEnvironment.WebRootPath}\\images\\{fileName}";
            if (File.Exists(path))
            {
                File.Delete(path);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            throw e;
        }
    }
}