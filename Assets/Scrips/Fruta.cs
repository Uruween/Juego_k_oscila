using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frutas : MonoBehaviour
{
    public Animator satoruGojo;
    [SerializeField] int score;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SimulationManager.Instance.score.AddScore(score);
            Collect();
        }
    }

    void Collect()
    {
        satoruGojo.SetTrigger("tocaFruta");
        Destroy(gameObject, 0.65f);
    }
}
