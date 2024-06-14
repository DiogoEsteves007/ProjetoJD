using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour
{
    [SerializeField] private Text BagsText;

    private void Start()
    {
        // Chama a função para definir o objetivo de moedas no início do jogo
        SetTargetCoins();
    }

    // Função para definir o objetivo de moedas aleatoriamente
    private void SetTargetCoins()
    {
        if(SceneManager.GetActiveScene().buildIndex == 2){
            BagsText.text = "Target: " + 950;
        }else if(SceneManager.GetActiveScene().buildIndex == 3){
            BagsText.text = "Target: " + 1300;
        }
    }

}
