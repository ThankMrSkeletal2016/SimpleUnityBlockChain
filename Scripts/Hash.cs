using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;

public class Hash : MonoBehaviour {
    ASCIIEncoding encoding = new ASCIIEncoding();

    public string Md5(string[] list1)
    {
        string finalHash = "";

        foreach (string str in list1)
        {
            byte[] bytes = encoding.GetBytes(str);
            var sha = new MD5CryptoServiceProvider();
            string hash = System.BitConverter.ToString(sha.ComputeHash(bytes));
            hash = hash.Substring(0, 4);
            finalHash = finalHash + hash;
        }
        return finalHash;
    }

    public int Md5Int(string[] list1)
    {
        int finalHash = 0;

        foreach (string str in list1)
        {
            byte[] bytes = encoding.GetBytes(str);
            var sha = new MD5CryptoServiceProvider();
            int hash = System.BitConverter.ToInt16(sha.ComputeHash(bytes),0);
            finalHash = finalHash + hash;
        }
        return finalHash;
    }
}
