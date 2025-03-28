using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private AudioSource audioSource;
    public GameObject particleEffectPrefab; // Sleep hier je particle effect prefab in

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public static event Action OnCollected;

    void Update()
    {
        transform.localRotation = Quaternion.Euler(90f, Time.time * 100f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnCollected?.Invoke();

            // Particle effect afspelen
            if (particleEffectPrefab != null)
            {
                Instantiate(particleEffectPrefab, transform.position, Quaternion.identity);
            }

            // Geluid afspelen
            if (audioSource != null)
            {
                audioSource.Play();
                StartCoroutine(DestroyAfterSound());
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }

    private IEnumerator DestroyAfterSound()
    {
        yield return new WaitForSeconds(audioSource.clip.length);
        Destroy(gameObject);
    }
}