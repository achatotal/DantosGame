using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_UI : MonoBehaviour
{
   public void PlayGame()
{
    SceneManager.LoadSceneAsync("SampleScene");
}

}