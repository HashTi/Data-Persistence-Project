using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] Text PlayerNameInput;
   
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void SetPlayerName()
    {
      PlayerDataHandle.Instance.PlayerName = PlayerNameInput.text;
    }

    public void Exit()
    {
      //  MainManager.Instance.SaveColor();
 //       if (UNITY_EDITOR)
 //       {
            EditorApplication.ExitPlaymode();
 //       }
 //       else
 //       {
 //           Application.Quit();
  //      }
    }


    
}
