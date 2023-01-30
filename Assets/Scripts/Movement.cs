using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private AudioClip arbolAudio;
    [SerializeField] private AudioClip rocaAudio;

    private AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.forward * y * Time.deltaTime);
        transform.Translate(Vector3.right * x * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Roca"))
        {
            _audioSource.PlayOneShot(rocaAudio);
        }

        if (collision.gameObject.CompareTag("Arbol"))
        {
            _audioSource.PlayOneShot(arbolAudio);
        }
    }
}
