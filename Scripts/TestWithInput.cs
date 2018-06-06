using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Cryptography;

public class TestWithInput : MonoBehaviour {

    Hash hash = new Hash();
    Color color = new Color();
    public string[] genesisTransactions = { "String 1", "String 2" };
    public string[] transations = { "String 3", "String 4" };

    ArrayList list = new ArrayList();

    private Block genesisBlock;
    public int counter = 0;
    public int previousHash = 0;

    private void Start()
    {
        genesisBlock = new Block(previousHash, genesisTransactions);
        previousHash = genesisBlock.GetBlockHash();
        print(previousHash);
        list.Add(genesisBlock);
        counter++;
    }  

    private void Update()
    {
        if(Input.GetKeyDown("space")){
            Block block = new Block(previousHash, transations);
            previousHash = block.GetBlockHash();
            list.Add(block);
            int colorCounter = 1;
            foreach (Block listedBlock in list)
            {
                print(listedBlock.GetBlockHash());
                foreach(int color in listedBlock.GetRgb())
                {
                    print("Color " + counter + " equals " + color);
                    counter++;
                }
            }
            counter++;
        }
    }
}
