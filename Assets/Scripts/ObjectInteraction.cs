using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public GameObject uiObject; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {           
            uiObject.SetActive(true);
            Debug.Log("UI показано"); 
        }
    }

}