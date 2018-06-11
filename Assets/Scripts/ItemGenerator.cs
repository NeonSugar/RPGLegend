using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{

    public static ItemGenerator _ItemGenerator;
    

    void Awake()
    {
        _ItemGenerator = this;
    }
    
}
