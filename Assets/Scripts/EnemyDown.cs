using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDown : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerUp"))
        {
            Destroy(gameObject);
        }
    }
}
