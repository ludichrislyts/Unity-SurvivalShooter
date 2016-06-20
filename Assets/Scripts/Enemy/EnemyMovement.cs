using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
	Transform playerT;
	GameObject player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    NavMeshAgent nav;


    void Awake ()
    {
		player = GameObject.FindGameObjectWithTag ("Player");
        playerT = player.transform;
		playerHealth = player.GetComponent<PlayerHealth> ();
        enemyHealth = GetComponent <EnemyHealth> ();
        nav = GetComponent <NavMeshAgent> ();
    }


    void Update ()
    {
        if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        {
            nav.SetDestination (playerT.position);
        }
        else
        {
            nav.enabled = false;
        }
    }
}
