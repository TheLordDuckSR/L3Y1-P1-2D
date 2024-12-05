using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSreen : MonoBehaviour
{
     public void OnBackToMain()
     {
        SceneManager.LoadScene("MainMenu");
     }
     
}
