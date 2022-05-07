using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{
    public void TTS() {
        SceneManager.LoadScene(1);
    }
    public void STT() {
        SceneManager.LoadScene(0);
    }
    public void STTAR()
    {
        SceneManager.LoadScene(2);
    }
}
