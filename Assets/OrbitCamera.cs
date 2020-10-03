using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
    public Transform LookAt;
    public float Radius = 20;
    public float Speed = 90;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (LookAt != null)
        {
            float deg = Time.time * Speed;
            this.transform.position = new Vector3(LookAt.position.x + Radius * Mathf.Cos(deg), LookAt.position.y, LookAt.position.z + Radius * Mathf.Sin(deg));
            this.transform.LookAt(LookAt);
        }
    }
}
