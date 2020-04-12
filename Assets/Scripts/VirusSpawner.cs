using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusSpawner : MonoBehaviour

{
    public float maxTime =1;
    private float timer = 0;

    public float height;
    public GameObject Virus;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>maxTime){

            GameObject newVirus = Instantiate(Virus);
            newVirus.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

            timer = 0;
            Destroy(newVirus, 15);
        }

        timer+= Time.deltaTime;
    }
}
