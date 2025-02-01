using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject controlsPanel;

    public void StartGame()
    {
        SceneManager.LoadScene(1); 
    }

    public void ReturnToStart()
    {
        SceneManager.LoadScene(0); 
    }

    public void ShowControls()
    {
        controlsPanel.SetActive(true); 
    }

    public void HideControls()
    {
        controlsPanel.SetActive(false); 
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }
}
