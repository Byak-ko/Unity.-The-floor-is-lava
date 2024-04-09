using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasRenderModeChanger : MonoBehaviour
{
    public GameObject SettingsCanvas;
    
    public void EnablePauseCanvas()
    {
        SettingsCanvas.SetActive(true);
    }

    void Update()
    {
    
        if (Input.GetKeyDown(KeyCode.Escape))
        {
                if (SettingsCanvas.activeSelf)
                {

                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                    SettingsCanvas.SetActive(false);
                }
                else
                {
                    EnablePauseCanvas();

                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                }   
        }
    }
}