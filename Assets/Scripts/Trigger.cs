using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "NextLevel")
        {
        SceneManager.LoadScene("Level 3");
        }
        if(col.gameObject.tag == "Void")
        {
        Destroy(gameObject);
        }
        if(col.gameObject.tag == "NextLevel1")
        {
        SceneManager.LoadScene("Level 4");
        }
        if(col.gameObject.tag == "NextLevel2")
        {
        SceneManager.LoadScene("Level 5");
        }
        if(col.gameObject.tag == "SecretLevel")
        {
        SceneManager.LoadScene("SecretLevel");
        }
        if(col.gameObject.tag == "NextLeve3")
        {
        SceneManager.LoadScene("Level6");
        }
        if(col.gameObject.tag == "NextLevel4")
        {
        SceneManager.LoadScene("Level 6");
        }
        if(col.gameObject.tag == "NextLevel5")
        {
        SceneManager.LoadScene("Level 7");
        }
        if(col.gameObject.tag == "NextLevel6")
        {
        SceneManager.LoadScene("Level 8");
        }
        if(col.gameObject.tag == "StartMenu")
        {
        SceneManager.LoadScene("StartMenu");
        }
      //===============================================
        if(col.gameObject.tag == "DieLevel0")
        {
        SceneManager.LoadScene("Level 0");
        }
        if(col.gameObject.tag == "DieLevel3")
        {
        SceneManager.LoadScene("Level 3");
        }
        if(col.gameObject.tag == "DieLevel4")
        {
        SceneManager.LoadScene("Level 4");
        }
        if(col.gameObject.tag == "DieLevel5")
        {
        SceneManager.LoadScene("Level 5");
        }
        if(col.gameObject.tag == "DieLevel6")
        {
        SceneManager.LoadScene("Level 6");
        }
        if(col.gameObject.tag == "DieSecretLevel")
        {
        SceneManager.LoadScene("SecretLevel");
        }
        if(col.gameObject.tag == "DieLevel7")
        {
        SceneManager.LoadScene("Level 7");
        }
        if(col.gameObject.tag == "DieLevel8")
        {
        SceneManager.LoadScene("Level 8");
        }
        if(col.gameObject.tag == "DieLevel9")
        {
        SceneManager.LoadScene("Level 9");
        }
    }
}
