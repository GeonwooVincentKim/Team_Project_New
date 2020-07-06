using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Title : MonoBehaviour
{
    public Button Start;
    public Button Creator;
    public Button Exit;

    // Scene01 로 직행
    public void ChangetoIngameScene()
    {
        SceneManager.LoadScene("2floor");
    }

    // Creator 창으로 직행
    public void ChangetoCreatorScene()
    {
        SceneManager.LoadScene("Creator");
    }

    // 게임 종료
    public void GameExit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
