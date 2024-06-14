using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseScene : MonoBehaviour
{


    public void MenuInicial()
    {
        SceneManager.LoadScene(0);
    }

    public void GetLvl1()
    {
        SceneManager.LoadScene(2);

    }

   public void GetLvl2()
    {
        SceneManager.LoadScene(3);

    }




   
}
