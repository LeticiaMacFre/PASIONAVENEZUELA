using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PrimeiroQuiz : MonoBehaviour
{
    public TextMeshProUGUI textoPergunta;
    public Button resposta1;
    public Button resposta2;
    public Button resposta3;

    public string question = "¿Quién es la estatua?";
    public string[] answers = {"Simon Bolivar", "Tulio Gonzalo", "Francisco Antonio"};
    public int correctAnswerIndex = 2; // Índice da resposta correta

    void Start()
    {
        ShowQuestion();
    }

    void ShowQuestion()
    {
        textoPergunta.text = question;
        resposta1.GetComponentInChildren<TextMeshProUGUI>().text = answers[0];
        resposta2.GetComponentInChildren<TextMeshProUGUI>().text = answers[1];
        resposta3.GetComponentInChildren<TextMeshProUGUI>().text = answers[2];

        //resposta1.onClick.AddListener(() => CheckAnswer(0));
        //resposta2.onClick.AddListener(() => CheckAnswer(1));
        //resposta3.onClick.AddListener(() => CheckAnswer(2));
    }

    public void CheckAnswer(int selectedAnswer)
    {
        if (selectedAnswer == correctAnswerIndex)
        {

            Debug.Log("Resposta Correta!");
        }
        else
        {
            Debug.Log("Resposta Incorreta!");
        }
    }
}