using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    public class PasswordEncrypt
    {
        public string sPass(string Pass)
        {
            char[] LowerAlhpa = { 'a','b','c','d','e','f','g','h',
                              'i','j','k','l','m','n','o','p',
                              'q','r','s','t','u','v','w','x','y','z',
                               '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char[] LowerAlphaKey = {'!','@','#','$','%','^','&','*',
                              '(',')','_','+','{','}',':','<',
                              '>','?','1','2','=','-','0','9','5','q',
                               'a', 'm', 'w', 'n', 'e', 'b', 'r', 'v', 't', 'c' };
            char[] UpperAlpha =  { 'A','B','C','D','E','F','G','H',
                              'I','J','K','L','M','N','O','P',
                             'Q','R','S','T','U','V','W','X','Y','Z',' '};
            char[] UpperAlhpaKey =  {'Q','W','E','R','A','S','D','F',
                              'Z','X','C','V','M','N','B','L',
                              'K','J','H','P','O','I','U','T','Y','G' ,'@'};
            //Password Encryption
            string sStudentPass = Pass;
            char[] sCharsPass = sStudentPass.ToCharArray();
            int w = 0;
            foreach (char c in sCharsPass)
            {
                if (LowerAlhpa.Contains(c))
                {
                    int i = Array.IndexOf(LowerAlhpa, c);
                    sCharsPass[w] = LowerAlphaKey[i];
                }
                else if (UpperAlpha.Contains(c))
                {
                    int i = Array.IndexOf(UpperAlpha, c);
                    sCharsPass[w] = UpperAlhpaKey[i];
                }
                else
                    sCharsPass[w] = sCharsPass[w];
                w++;
            }
            return new string(sCharsPass);


        }
    }
}
