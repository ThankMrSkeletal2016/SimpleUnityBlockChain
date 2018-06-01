using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    private int previousHash;
    private string[] transactions;
    Hash hash = new Hash();

    private int blockHash;

    public Block(int previousHash, string[] transaction)
    {
        this.previousHash = previousHash;
        this.transactions = transaction;
        this.blockHash = hash.Md5Int(transaction) + previousHash;
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

}
