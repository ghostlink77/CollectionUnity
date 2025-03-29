using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashtableEx : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Hashtable hash = new Hashtable();

        hash.Add(1, "integer");
        hash.Add(1.2f, "real number");
        hash.Add("Hello", "string");

        foreach(object key in hash.Keys)
        {
            Debug.Log($"hash[{key}] = {hash[key]}");
        }

        if (hash.ContainsKey("Hello")) Debug.Log("Å° Á¸Àç");

        Debug.Log($"Hashtable Count : {hash.Count}");

        // remove by key
        hash.Remove(1);

        foreach (object key in hash.Keys)
        {
            Debug.Log($"hash[{key}] = {hash[key]}");
        }

        hash.Clear();
        Debug.Log($"Hashtable Count : {hash.Count}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
