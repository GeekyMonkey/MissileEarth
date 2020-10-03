using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidGenerator : MonoBehaviour
{
    public GameObject[] AsteroidPrefabs;
    public float Radius;
    public float SecondsBetween;
    private float NextLaunch;

    // Start is called before the first frame update
    void Start()
    {
        NextLaunch = SecondsBetween;
    }

    // Update is called once per frame
    void Update()
    {
        NextLaunch -= Time.deltaTime;
        if (NextLaunch < 0)
        {
            Launch();
            NextLaunch = SecondsBetween;
        }

    }

    private void Launch()
    {
        float angle = Random.Range(0, 360);
        Vector3 pos = new Vector3(0, Mathf.Sin(angle), Mathf.Cos(angle));                     
        Instantiate(this.AsteroidPrefabs[0], pos * Radius, Quaternion.Euler(Random.Range(0,360), Random.Range(0, 360), Random.Range(0, 360)));
    }
}
