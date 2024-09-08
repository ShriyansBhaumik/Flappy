using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnTime=2;
    private float timer = 0;
    public float heightOffSet;  


    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();    
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<spawnTime)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            SpawnPipe();
        }
        
       
        
    }

    public void SpawnPipe ()
    {
        float lowest= transform.position.y - heightOffSet;  
        float highest= transform.position.y + heightOffSet;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowest, highest), 0), transform.rotation);
        

       


    }
}
