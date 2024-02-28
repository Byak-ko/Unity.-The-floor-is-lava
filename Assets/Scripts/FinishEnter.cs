using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishEnter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Time.timeScale = 0f;
        }
    }
}