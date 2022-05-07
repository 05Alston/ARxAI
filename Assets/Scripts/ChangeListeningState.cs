using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeListeningState : MonoBehaviour
{
    public VoiceController voiceController;
    public void StartSession()
    {
        voiceController.StartListening();
        StartCoroutine(ChangeState());
        Debug.Log("EndChangeState");
    }
    IEnumerator ChangeState()
    {
        Debug.Log("ChangeState");
        yield return new WaitForSeconds(5f);
        EndSession();
        Debug.Log("EndSession");
    }
    void EndSession()
    {
        voiceController.StopListening();
    }
}
