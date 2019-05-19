using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateArround : MonoBehaviour
{
    public GameObject Earth;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Earth.transform.position, Earth.transform.up, 100 * Time.deltaTime);

    }
}
