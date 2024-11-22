using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TesteQuiz : MonoBehaviour
{
    public string botaoUm;
    public string botaoDois;
    public string botaoTres;
    public string botaoQuatro;

    public TMP_Text PrimeiraOpcao;
    public TMP_Text SegundaOpcao;
    public TMP_Text TerceiraOpcao;
    public TMP_Text QuartaOpcao;

    public int limitedetempo;

    // Start is called before the first frame update
    void Start()
    {
        PrimeiraOpcao.text = botaoUm;
        SegundaOpcao.text = botaoDois;
        TerceiraOpcao.text = botaoTres;
        QuartaOpcao.text = botaoQuatro;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // três botões terão o método RespostaIncorreta() e um RespostaCorreta()
    private void RespostaCorreta()
    {
        Debug.Log("resposta correta!");
        //proxima cena
    }

    private void RespostaIncorrta()
    {
        Debug.Log("reposta incorreta");
    }
}
