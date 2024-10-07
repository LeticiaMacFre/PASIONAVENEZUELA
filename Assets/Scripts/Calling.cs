using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calling : MonoBehaviour
{
    [SerializeField] private AudioClip voice;
    [SerializeField] private AudioClip ringging;
    [SerializeField] private GameObject callApp;
    private AudioSource audioS;
    [SerializeField] private bool isCalling = false;

    // Start is called before the first frame update
    void Start()
    {
        audioS = GetComponent<AudioSource>();
        callApp.SetActive(false);
        StartCoroutine(CounterToCall());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayVoice()
    {
        StartCoroutine(PlayCall());
    }

    public bool IsCalling()
    {
        callApp.SetActive(true);
        audioS.PlayOneShot(ringging);
        StartCoroutine(VibraCall());
        return isCalling;
    }

    public void AcceptCalling()
    {
        isCalling = false;
    }

    public void StopCalling()
    {
        isCalling = false;
        callApp.SetActive(false);
        StartCoroutine(CounterToCall());
    }

    IEnumerator CounterToCall()
    {
        yield return new WaitForSeconds(Random.Range(2.5f, 5.5f));
        isCalling = true;
        IsCalling();
        StopCoroutine(CounterToCall());
    }

    IEnumerator PlayCall()
    {
        audioS.Stop();
        yield return new WaitForSeconds(0.5f);
        audioS.PlayOneShot(voice);
        yield return new WaitForSeconds(8.0f);
        callApp.SetActive(false);
        StopCoroutine(PlayCall());
    }

    IEnumerator VibraCall()
    {
        do
        {

            yield return new WaitForSeconds(0.5f);
            Handheld.Vibrate();

        }while(isCalling);

        StopCoroutine(VibraCall());
    }
}
