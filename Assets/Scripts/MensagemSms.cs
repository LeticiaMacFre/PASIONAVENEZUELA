using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine;

[CreateAssetMenu(fileName = "Nova Mensagem", menuName = "Mensagem SMS")]
public class MensagemSms : ScriptableObject
{
    public string remetente;
    public string mensagem;
    public string nomeCenaAr;
    public bool lida;

    public string PegaRemetente()
    {
        return remetente;
    }

    public string PegaMensagem()
    {
        return mensagem;
    }

    public string PegaCenaAr()
    {
        return nomeCenaAr;
    }

    public bool PegaLida()
    {
        return lida;
    }

    public void MarcaComoLida()
    {
        lida = true;
    }
}
