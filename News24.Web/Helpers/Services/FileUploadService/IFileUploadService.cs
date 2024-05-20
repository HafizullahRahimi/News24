using Microsoft.AspNetCore.Components.Forms;

namespace News24.Web.Helpers.Services.FileUploadService;
public interface IFileUploadService
{
    Task<string> UploadFile(IBrowserFile file);
    bool DeleteFile(string fileName);
}