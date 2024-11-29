using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjetoArManager : MonoBehaviour
{
    [SerializeField] private GameObject telaAr;
    [SerializeField] private TextMeshProUGUI contagemMsg;
    [SerializeField] private GameObject notificacao;
    [SerializeField] private List<ObjetoAr> mensagens = new List<ObjetoAr>();

    public void AbrirTelaAr()
    {
        telaAr.SetActive(true);
    }

    public void FecharTelaAr()
    {
        telaAr.SetActive(false);
    }

    public void FecharLerAr()
    {
        notificacao.SetActive(false);
    }

}
