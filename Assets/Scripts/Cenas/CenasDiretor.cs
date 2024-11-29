using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class CenasDiretor : MonoBehaviour
{

    public string nomeDaCena;
    
    public void SwitchScene()
    {
        SceneManager.LoadScene(nomeDaCena);
    }
}
