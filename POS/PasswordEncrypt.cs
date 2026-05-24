using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace POS
{
    public class PasswordEncrypt
    {
        // Store keys as private static readonly so they're hidden from outside
        private static readonly char[] LowerAlpha = {
            'a','b','c','d','e','f','g','h','i','j','k','l','m',
            'n','o','p','q','r','s','t','u','v','w','x','y','z',
            '1','2','3','4','5','6','7','8','9','0'
        };

        private static readonly char[] LowerAlphaKey = {
            '!','@','#','$','%','^','&','*','(',')',
            '_','+','{','}',':','<','>','?','1','2',
            '=','-','0','9','5','q','a','m','w','n',
            'e','b','r','v','t','c'
        };

        private static readonly char[] UpperAlpha = {
            'A','B','C','D','E','F','G','H','I','J','K','L','M',
            'N','O','P','Q','R','S','T','U','V','W','X','Y','Z',' '
        };

        private static readonly char[] UpperAlphaKey = {
            'Q','W','E','R','A','S','D','F','Z','X','C','V','M',
            'N','B','L','K','J','H','P','O','I','U','T','Y','G','@'
        };

        // ENCRYPT — plain text -> encrypted
        public string Encrypt(string pass)
        {
            char[] chars = pass.ToCharArray();
            for (int w = 0; w < chars.Length; w++)
            {
                int i = Array.IndexOf(LowerAlpha, chars[w]);
                if (i >= 0) { chars[w] = LowerAlphaKey[i]; continue; }

                int j = Array.IndexOf(UpperAlpha, chars[w]);
                if (j >= 0) { chars[w] = UpperAlphaKey[j]; }
            }
            return new string(chars);
        }

        // DECRYPT — encrypted -> plain text
        public string Decrypt(string encryptedPass)
        {
            char[] chars = encryptedPass.ToCharArray();
            for (int w = 0; w < chars.Length; w++)
            {
                int i = Array.IndexOf(LowerAlphaKey, chars[w]);
                if (i >= 0) { chars[w] = LowerAlpha[i]; continue; }

                int j = Array.IndexOf(UpperAlphaKey, chars[w]);
                if (j >= 0) { chars[w] = UpperAlpha[j]; }
            }
            return new string(chars);
        }

        // Keep old method name working so nothing else breaks
        public string sPass(string pass) => Encrypt(pass);
    }
}