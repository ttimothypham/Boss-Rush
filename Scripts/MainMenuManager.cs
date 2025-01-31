using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject controlsPanel;

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene"); 
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
