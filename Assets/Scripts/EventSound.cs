using UnityEngine;
using UnityEngine.Events;

public class EventSound : MonoBehaviour
{
    public UnityEvent onEventTriggered;
    public AudioClip soundEffect; 

    private AudioSource audioSource;

    private void Start()
    {
        onEventTriggered.AddListener(PlaySoundEffect);

        audioSource = GetComponent<AudioSource>();
    }

    private void PlaySoundEffect()
    {
        audioSource.PlayOneShot(soundEffect);
    }
    private void OnCollisionEnter(Collision collision)
    { 
        if (collision.gameObject.CompareTag("Wall"))
        {

            onEventTriggered.Invoke();
        }
    }
}
