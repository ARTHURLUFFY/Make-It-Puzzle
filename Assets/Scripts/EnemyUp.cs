using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerDown"))
        {
            Destroy(gameObject);
        }
    }
}
