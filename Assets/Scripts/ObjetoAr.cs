using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ObjetoAr : MonoBehaviour
{
    [SerializeField] private string nomeObjeto;
    [SerializeField] private TextMeshProUGUI objetoNome;
    [SerializeField] private bool novoObjeto;
    [SerializeField] private string nomeCenaObjeto;
    [SerializeField] private Button botaoAcesso;

    // Start is called before the first frame update
    private void Awake()
    {
        objetoNome.text = nomeObjeto;
        novoObjeto = true;
        botaoAcesso.onClick.AddListener(IrParaACena);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IrParaACena()
    {
        novoObjeto = false;
        SceneManager.LoadScene(nomeCenaObjeto);
    }
}
