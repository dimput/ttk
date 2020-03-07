using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectAvail : MonoBehaviour
{
    public GameObject dimas, objectToSpawn;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!dimas)
        {
            print("tidak ada");
            GameObject obj = Instantiate(objectToSpawn, this.transform);
            dimas= obj;
        }
    }
}
