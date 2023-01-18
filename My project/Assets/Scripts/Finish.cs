using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public ParticleSystem[] particles;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            OpenParticles();

            GameManager.Instance.OnLevelFinished();
        }
    }

    public void OpenParticles()
    {
        for (int i = 0; i < particles.Length; i++)
        {
            particles[i].Play();
        }
    }
}
