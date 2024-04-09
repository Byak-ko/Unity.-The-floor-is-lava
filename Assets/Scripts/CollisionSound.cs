using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    public ParticleSystem Particles;
    public GameObject Player;
    public GameObject GameUI;
    public AudioClip Sound;
    private AudioSource _audioSource;
    [SerializeField]
    private AudioSource _backgroundMusic;
    private bool IsSoundPlayed = false;
    public GameObject uiObject;


    private void Start()
    {
        Particles.Stop();
        IsSoundPlayed = false;
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        PlayGameOverSound(collision.gameObject.CompareTag("Player") ? Sound : null);
    }

    private void PlayGameOverSound(AudioClip sound)
    {
        if (sound != null && !IsSoundPlayed)
        {
            if (Particles != null)
            {
                Instantiate(Particles, Player.transform.position, Quaternion.identity);
                _audioSource.PlayOneShot(_audioSource.clip);
            }

            Player.SetActive(false);
            GameUI.SetActive(false);

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            uiObject.SetActive(true);
            _audioSource.PlayOneShot(sound);
            _backgroundMusic.enabled = false;
            IsSoundPlayed = true;
        }
    }

}

