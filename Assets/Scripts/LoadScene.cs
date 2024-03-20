using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public int SceneNumber;

    public void LoadSelectedScene()
    {
        SceneManager.LoadScene(SceneNumber);
    }
}
