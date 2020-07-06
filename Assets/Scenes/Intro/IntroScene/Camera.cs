using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Camera : MonoBehaviour
{
    public float speed;
    float timer;
    float waitingTime;
    bool inside;
    // Fade Scene은 이미 Animator로 구현해놓았으므로, 필요성을 느끼지 못할 것 같습니다.
    // 일단 나중에 필요할 수도 있으니 주석처리를 하도록 하겠습니다.
    /*
     * public FadeScene Fade;
     * IEnumerator Activate()
     * {
     *     yield return new WaitForSeconds(3f);
     *     Fade.FadeIn(0.6f, () =>
     *     {
     *         UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("IntroScene");
     *     });
     * }
     */
    void Start()
    {
        timer = 0.0f;
        waitingTime = 4.5f;
        inside = false;
    }


    void Update()
    {
        // Blocked this code because it doesn't work.
        // 이 코드는 제대로 작동이 되지 않아 일단 주석처리를 해놓았습니다.
        // StartCoroutine(Activate());

        // 360도 회전 기능 --> 맵 계속 돌아다님
        timer += Time.deltaTime;
        float fMove = Time.deltaTime * speed;

        if (timer < waitingTime)
        {
            if(timer >= 0.0f && timer <= 3.0f)
            {
                transform.Rotate(0, speed * Time.deltaTime, 0);
            }
            if(timer >= 3.0f && timer <= 4.5f)
            {
                transform.Translate(Vector3.left * fMove + Vector3.down * fMove);
            }
        }
        //if(timer == waitingTime) { 
        //    transform.Translate(Vector3.forward * fMove);
        //}
        if (timer == waitingTime)
        {
            if(timer == 4.5f && waitingTime == 4.5f)
            {
                transform.Translate(Vector3.right * fMove + Vector3.up * fMove);
            }
            //transform.Rotate(-180, speed * Time.deltaTime, 0);
        }
        if(timer > waitingTime)
        {
            if(timer >= 4.5f && timer <= 10.0f)
            {
                transform.Translate(Vector3.up * fMove);
            }
            if(timer >= 10.0f)
            {
                transform.Rotate(0, speed * Time.deltaTime, 0);
            }
        }
        
        //FadeIn(0.2, );
        // Go to Title Scene when input anykey.
        // 아무 키나 누르면 Title Scene으로 직행
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("Title");
        }
    }
}
