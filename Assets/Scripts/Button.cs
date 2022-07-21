using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void ButtonPress()
    {
        SceneManager.LoadScene("Level 0");
    }
    public void ButtonPressLevels()
    {
        SceneManager.LoadScene("Levels");
    }

    public void ButtonPressLevel1()
    {
        SceneManager.LoadScene("Level 0");
    }


    public void ButtonPressLevel3()
    {
        SceneManager.LoadScene("Level 3");
    }
    public void ButtonPressLevel4()
    {
        SceneManager.LoadScene("Level 4");
    }
    public void ButtonPressLevel5()
    {
        SceneManager.LoadScene("Level 5");
    }
    public void ButtonPressLevel6()
    {
        SceneManager.LoadScene("Level 6");
    }
    public void ButtonPressLevel7()
    {
        SceneManager.LoadScene("Level 7");
    }
    public void ButtonPressLevel8()
    {
        SceneManager.LoadScene("Level 8");
    }
    public void ButtonPressLevel9()
    {
        SceneManager.LoadScene("Level 9");
    }
    public void ButtonPressLevelDontKnow()
    {
        SceneManager.LoadScene("SecretLevel");
    }
    public void ButtonPressLevelBack()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void Home(int scaneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(scaneID);
    }
    
}
