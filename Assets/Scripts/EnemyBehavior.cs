using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        GetComponent<NavMeshAgent>().SetDestination(player.transform.position);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
