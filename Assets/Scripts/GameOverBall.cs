using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverBall : MonoBehaviour
{
    [SerializeField]
    private AudioClip _gameOverSound;
    [SerializeField]
    private AudioSource _audioSource;
    [SerializeField]
    private AudioSource _backgroundMusic;

    private bool isSoundPlayed = false;

    private void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        PlayGameOverSound(collision.gameObject.CompareTag("Lava") ? _gameOverSound : null);
    }

    private void PlayGameOverSound(AudioClip sound)
    {
        if (!isSoundPlayed)
        {
            _audioSource.PlayOneShot(sound);
            _backgroundMusic.enabled = false;
            isSoundPlayed = true;
        }
    }
}
