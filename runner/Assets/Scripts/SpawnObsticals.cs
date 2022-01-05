using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObsticals : MonoBehaviour
{
    // setting up vars


    //calling obstical
    public GameObject obstical;

    //timing
    float startupTime = 2f;
    float spawnTime = 1.5f;
    
    //



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawobsticals",startupTime,spawnTime);
    }

    // spawns obsticals
    void spawobsticals()
    {
        Instantiate(obstical, transform.position , obstical.transform.rotation);
    }
}
