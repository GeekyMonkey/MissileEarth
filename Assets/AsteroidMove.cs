using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMove : MonoBehaviour
{
    public float acceleration;
    public Vector3 velocity;
    public float EarthRadius;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.velocity -= this.transform.position * acceleration * Time.deltaTime;
        this.transform.position = this.transform.position + velocity;

        if (transform.position.magnitude < EarthRadius)
        {
            HitEarth();
        }
    }

    private void HitEarth()
    {
        Destroy(this.gameObject);
    }
}
