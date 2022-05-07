using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextToSpeech : MonoBehaviour
{
    public AudioSource _audio;
    public InputField inputText;

    // Start is called before the first frame update
    void Start()
    {
        _audio = gameObject.GetComponent<AudioSource>();
        StartCoroutine(DownloadTheAudio());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator DownloadTheAudio()
    {
        string url = "http://translate.google.com/translate_tts?ie=UTF-8&idx=O&textlen=32&client=tw-ob&q=" + inputText.text + "&tl=En-gb";
        WWW www = new WWW(url);
        yield return www;

        _audio.clip = www.GetAudioClip(false, true, AudioType.MPEG);
        _audio.Play();
    }

    public void ButtonClick()
    {
        Debug.Log("Pressed");
        StartCoroutine(DownloadTheAudio());
    }

}