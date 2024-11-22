using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SmsMensagem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nome;
    [SerializeField] private MensagemSms mensagem;
    [SerializeField] private SmsManager smsManager;
    [SerializeField] private Button botaoLer;

    private void Awake()
    {
        smsManager = FindObjectOfType<SmsManager>();
        nome.text = mensagem.PegaRemetente();
        botaoLer.onClick.AddListener(() => smsManager.AbrirLerSms(mensagem));
    }
}
