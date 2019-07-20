using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportButtonTrigger : MonoBehaviour
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
    void OnTriggerEnter(Collider other)
    {

        Player.position = spawnPoint.position;

    }
}
