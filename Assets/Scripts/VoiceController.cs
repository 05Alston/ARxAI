using System.Collections;
using System.Collections.Generic;
using TextSpeech;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Android;

public class VoiceController : MonoBehaviour
{
    const string LANG_CODE = "en-US";

    [SerializeField]
    Text uiText;

    void Start(){
        Setup(LANG_CODE);

#if UNITY_ANDROID
        SpeechToText.instance.onPartialResultsCallback = OnPartialSpeechResult;

#endif        
        SpeechToText.instance.onResultCallback = OnFinalSpeechResult;
        CheckPermission();
    }

    void CheckPermission(){
#if UNITY_ANDROID
       if (!Permission.HasUserAuthorizedPermission(Permission.Microphone)){
           Permission.RequestUserPermission(Permission.Microphone);
       } 
#endif       

    }

    #region Speech To Text
     public void StartListening(){
         SpeechToText.instance.StartRecording();
         Debug.Log("Hella");
     }

     public void StopListening(){
        Debug.Log("Sucks");
        SpeechToText.instance.StopRecording();

     }
    
    void OnFinalSpeechResult(string result){
        uiText.text = result;
        
    }
    void OnPartialSpeechResult(string result){
        uiText.text = result;
    }

    #endregion

    void Setup(string code){
        SpeechToText.instance.Setting(code);
    }
    
}
