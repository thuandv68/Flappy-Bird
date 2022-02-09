using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject pipe;
    public float maxTime;
    private float timer;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime) {
            GameObject tmp = Instantiate(pipe, new Vector3(transform.position.x, transform.position.y + Random.Range(-height, height), 0), Quaternion.identity);
            Destroy(tmp, 8f);
            timer = 0;
        }   

        timer += Time.deltaTime;
    }
}
