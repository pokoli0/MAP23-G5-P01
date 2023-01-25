using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlock : MonoBehaviour
{
    // Start is called before the first frame update
    
    private void OnTriggerEnter2D(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(gameObject);
        }
        
    }
}
