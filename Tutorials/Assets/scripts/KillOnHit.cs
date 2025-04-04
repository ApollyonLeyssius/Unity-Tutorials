using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOnHit : MonoBehaviour
{
    public string targetTag;
    public GameObject effect;
    private AudioSource audioSource;

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.CompareTag(targetTag))
        {
            if (effect != null)
            {
                GameObject ob = Instantiate(effect);
                Destroy(ob, 3f);
            }
            if (audioSource != null)
            {
                audioSource.Play();
            }
            Destroy(coll.gameObject);
        }

    }
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.CompareTag(targetTag))
        {
            if (effect != null)
            {
                GameObject ob = Instantiate(effect);
                Destroy(ob, 3f);
            }
            if (audioSource != null)
            {
                audioSource.Play();
            }
            Destroy(coll.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
