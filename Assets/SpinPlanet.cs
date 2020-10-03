using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPlanet : MonoBehaviour
{
    public float speed = 90;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, speed * Time.deltaTime, 0, Space.World);
    }
}
