using System.Security.Cryptography;
using System.Text;
namespace JoLab.Infrastructure.Extensions
{
    public static class JoLabExtensions
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }
        public static string HashedPassword(this string password) => string.Join("", SHA1.Create().ComputeHash(Encoding.UTF8.GetBytes(password)).Select(x => x.ToString("X2"))).ToUpper();
        public static async Task<string> UplodaFiles(this string base64, string type = ".apk",string folder="applications")
        {
            string fileName = Guid.NewGuid().ToString("N") + type;
            string path = @"C:\inetpub\wwwroot\DcpMdm.FE\assets\"+ folder;
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            string filePath = Path.Combine(path, fileName);
            await File.WriteAllBytesAsync(filePath, Convert.FromBase64String(base64));
            return fileName;
        }
    }
}
