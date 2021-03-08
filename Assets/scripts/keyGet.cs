using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyGet : MonoBehaviour { 

    public GameObject locked;
    public GameObject key1;
    public GameObject locked2;
    public GameObject key2;
    public GameObject locked3;
    public GameObject key3;
    public GameObject key4;
    public GameObject knockout;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == key1)
        {
          
            Destroy(locked);
            Destroy(key1);
        }
        if (other.gameObject == key2)
        {

            Destroy(locked2);
            Destroy(key2);
        }
        if (other.gameObject == key3)
        {

            Destroy(locked3);
            Destroy(key3);
        }

        if (other.gameObject == key4)
        {

            Destroy(knockout);
            Destroy(key4);
        }
    }
}

