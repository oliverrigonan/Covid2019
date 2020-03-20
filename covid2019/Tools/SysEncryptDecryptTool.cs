using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace covid2019.Tools
{
    public class SysEncryptDecryptTool
    {
        public String EncryptString(string textToEncrypt)
        {
            try
            {
                String ToReturn = "";
                String _key = "harold@@glenn!!minerva##1977";
                String _iv = "abc@98797hjkas$&asd(*$%";

                Byte[] _keybyte = Encoding.UTF8.GetBytes(_key.Substring(0, 8));
                Byte[] _ivByte = Encoding.UTF8.GetBytes(_iv.Substring(0, 8));

                MemoryStream memoryStream = null;
                CryptoStream cryptoStream = null;

                Byte[] inputbyteArray = Encoding.UTF8.GetBytes(textToEncrypt);

                using (DESCryptoServiceProvider desCryptoServiceProvider = new DESCryptoServiceProvider())
                {
                    memoryStream = new MemoryStream();

                    cryptoStream = new CryptoStream(memoryStream, desCryptoServiceProvider.CreateEncryptor(_keybyte, _ivByte), CryptoStreamMode.Write);
                    cryptoStream.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cryptoStream.FlushFinalBlock();

                    ToReturn = Convert.ToBase64String(memoryStream.ToArray());
                }

                return ToReturn;
            }
            catch (Exception ae)
            {
                throw new Exception(ae.Message, ae.InnerException);
            }
        }

        public String DecryptString(string textToDecrypt)
        {
            try
            {
                String ToReturn = "";
                String _key = "harold@@glenn!!minerva##1977";
                String _iv = "abc@98797hjkas$&asd(*$%";

                Byte[] _ivByte = Encoding.UTF8.GetBytes(_iv.Substring(0, 8));
                Byte[] _keybyte = Encoding.UTF8.GetBytes(_key.Substring(0, 8));

                MemoryStream memoryStream = null;
                CryptoStream cryptoStream = null;

                Byte[] inputbyteArray = new Byte[textToDecrypt.Replace(" ", "+").Length];
                inputbyteArray = Convert.FromBase64String(textToDecrypt.Replace(" ", "+"));

                using (DESCryptoServiceProvider desCryptoServiceProvider = new DESCryptoServiceProvider())
                {
                    memoryStream = new MemoryStream();

                    cryptoStream = new CryptoStream(memoryStream, desCryptoServiceProvider.CreateDecryptor(_keybyte, _ivByte), CryptoStreamMode.Write);
                    cryptoStream.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cryptoStream.FlushFinalBlock();

                    Encoding encoding = Encoding.UTF8;
                    ToReturn = encoding.GetString(memoryStream.ToArray());
                }

                return ToReturn;
            }
            catch (Exception ae)
            {
                throw new Exception(ae.Message, ae.InnerException);
            }
        }
    }
}
