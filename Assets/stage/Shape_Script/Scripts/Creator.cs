using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Creator : MonoBehaviour
{
    public Button Back;

    // Go to Title_Scene when User click 'Back' Button.
    // 유저가 'Back'버튼을 누르면 Title Scene으로 향합니다.
    public void ChangetoStartScene()
    {
        SceneManager.LoadScene("Title");
    }
}
