using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Cryptography;

public class Test : MonoBehaviour {

    Hash hash = new Hash();
    Color color = new Color();
    public string[] genesisTransactions = { "String 1", "String 2" };
    public string[] block2Transations = { "String 3", "String 4" };
    public string[] block3Transations = { "String 5", "String 6" };

    ArrayList list = new ArrayList();

    private void Main()
    {
        Block genesisBlock = new Block(0, genesisTransactions);
        string genHash = genesisBlock.GetBlockHash().ToString();
        print(genHash);
        list.Add(genesisBlock);

        Block block2 = new Block(genesisBlock.GetBlockHash(), block2Transations);
        genHash = block2.GetBlockHash().ToString();
        print(genHash);
        list.Add(block2);

        Block block3 = new Block(block2.GetBlockHash(), block3Transations);
        genHash = block3.GetBlockHash().ToString();
        print(genHash);
        list.Add(block3);
    }  
}
