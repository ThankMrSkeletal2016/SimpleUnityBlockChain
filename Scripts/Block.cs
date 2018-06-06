using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    private int previousHash;
    private string[] transactions;
    Hash hash = new Hash();
    Color color = new Color();

    private int blockHash;
    private string hashString;
    private List<int> rgb;

    public Block(int previousHash, string[] transaction)
    {
        this.previousHash = previousHash;
        this.transactions = transaction;
        this.blockHash = hash.Md5Int(transaction) + previousHash;
        this.hashString = blockHash.ToString();
        this.rgb = color.ColorChange(blockHash);
    }

    public int GetPreviousHash()
    {
        return previousHash;
    }

    public string[] GetTransaction()
    {
        return transactions;
    }

    public int GetBlockHash()
    {
        return blockHash;
    }

    public string GetHashString()
    {
        return hashString;
    }

    public List<int> GetRgb()
    {
        return rgb;
    }
}
