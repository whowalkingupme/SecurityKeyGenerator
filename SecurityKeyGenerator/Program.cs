using System.Security.Cryptography;

namespace SecurityKeyGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 生成一個 32 字節的隨機金鑰
            byte[] key = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(key);
            }

            // 轉換成 Base64 字串
            string base64Key = Convert.ToBase64String(key);
            Console.WriteLine($"Generated TokenSecret: {base64Key}");
        }
    
    }
}
