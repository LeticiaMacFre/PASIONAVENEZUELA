using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LerSms : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nombre;
    [SerializeField] private TextMeshProUGUI texto;

    public void SetMensagem(MensagemSms mensagem)
    {
        nombre.text = mensagem.PegaRemetente();
        texto.text = mensagem.PegaMensagem();
        mensagem.MarcaComoLida();
    }

    public void Fechar()
    {
        nombre.text = "";
        texto.text = "";
    }
}
