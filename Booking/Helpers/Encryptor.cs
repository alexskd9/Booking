namespace Booking.Helpers
{
    public class Encryptor
    {
        public static string SHA512Hash(string input)
        {
            byte[] data = System.Security.Cryptography.SHA512.Create().ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
            string sha512 = "";
            for (int i = 0; i < data.Length; i++)
            {
                sha512 += data[i].ToString("x2");
            }
            return sha512;
        }
    }
}
