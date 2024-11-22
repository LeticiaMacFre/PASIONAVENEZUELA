using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.XR.CoreUtils;
using UnityEngine;

public class SmsManager : MonoBehaviour
{
    [SerializeField] private GameObject telaSms;
    [SerializeField] private GameObject lerSms;
    [SerializeField] private TextMeshProUGUI contagemMsg;
    [SerializeField] private GameObject notificacao;
    [SerializeField] private List<MensagemSms> mensagens = new List<MensagemSms>();

    public void AbrirTelaSms()
    {
        telaSms.SetActive(true);
    }

    public void FecharTelaSms()
    {
        telaSms.SetActive(false);
    }

    public void AbrirLerSms(MensagemSms mensagem)
    {
        lerSms.SetActive(true);
        lerSms.GetComponent<LerSms>().SetMensagem(mensagem);
    }

    public void FecharLerSms()
    {
        lerSms.SetActive(false);
        notificacao.SetActive(false);
    }


}
