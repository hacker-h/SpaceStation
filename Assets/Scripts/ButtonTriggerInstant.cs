using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTriggerInstant : MonoBehaviour
{

    [SerializeField]
    private Transform Player;
    [SerializeField]
    private Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Player.position = spawnPoint.position;
    }
}
