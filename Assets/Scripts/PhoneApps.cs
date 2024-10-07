using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhoneApps : MonoBehaviour
{
    [SerializeField] private GameObject calling;
    private Calling call;
    // Start is called before the first frame update
    void Start()
    {
        call = calling.GetComponent<Calling>();
    }

    public void AcceptCall()
    {
        call.AcceptCalling();
        call.PlayVoice();
    }

    public void CloseCall()
    {
        call.StopCalling();
    }

    public void OpenCamera()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
