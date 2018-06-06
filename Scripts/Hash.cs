using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;

public class Hash : MonoBehaviour {
    ASCIIEncoding encoding = new ASCIIEncoding();

    public string Md5(string[] list1)
    {
        int hash = Md5Int(list1);
        string finalHash = hash.ToString();
        return finalHash;
    }

    public int Md5Int(string[] list1)
    {
        int finalHash = 0;

        foreach (string str in list1)
        {
            byte[] bytes = encoding.GetBytes(str);
            var md5 = new MD5CryptoServiceProvider();
            int hash = System.BitConverter.ToInt16(md5.ComputeHash(bytes),0);
            finalHash = finalHash + hash;
        }
        return finalHash;
    }
}
