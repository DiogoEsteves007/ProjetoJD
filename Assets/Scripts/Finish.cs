using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System.Linq;

public class Finish : MonoBehaviour
{
    private AudioSource finishSound;
    private bool levelcompleted = false;

    [SerializeField] private Text TargetBags;
    [SerializeField] private Text BagsText;

    [SerializeField] AudioSource estapalpitado;



    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelcompleted)
        {
            finishSound.Play();
            estapalpitado.Play();

            levelcompleted = true;
             int targetBags, bags;


              if(SceneManager.GetActiveScene().buildIndex == 1)
        {
                    Invoke("CompleteLevel", 4f);
                    TimerController.instance.EndTimer();
                    SaveTime();
                    
        }else{

            if (int.TryParse(TargetBags.text.Replace("Target: ", ""), out targetBags) &&
                int.TryParse(BagsText.text.Replace("Peso: ", ""), out bags))
            {
                Debug.Log("Target Bags: " + targetBags);
                Debug.Log("Bags: " + bags);

                if (IsBagsInRange(targetBags, bags))
                {
                
                    Invoke("CompleteLevel", 4f);
                    TimerController.instance.EndTimer();
                    SaveTime();

                }
                else
                {
                    Debug.Log("Bags are not in the required range.");
                    Invoke("lose", 4f);
                    TimerController.instance.EndTimer();
                    SaveTime();
                }
            }
            else
            {
                Debug.LogError("Failed to parse target bags or bags.");
            }

        }

        }
    }



    private void CompleteLevel()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
                SceneManager.LoadScene(0);
        }else{
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);

        }
    }

    private void lose(){
        if(SceneManager.GetActiveScene().buildIndex == 2){
            SceneManager.LoadScene(5);
        }else if(SceneManager.GetActiveScene().buildIndex == 3){
            SceneManager.LoadScene(6);
        }
        
    }

      private bool IsBagsInRange(int targetBags, int bags)
    {
        return bags >= targetBags - 150 && bags <= targetBags + 150;
    }

    private void SaveTime()
    {
        // Retrieve the time from the Text component with tag "Timer"
        Text timerText = GameObject.FindGameObjectWithTag("Timer").GetComponent<Text>();
        string timeString = timerText.text.Replace("Time: ", "").Trim();
        
        string filePath = "";
        if(SceneManager.GetActiveScene().buildIndex == 2){
            filePath = Application.persistentDataPath + "/times_1.txt";

        }else if(SceneManager.GetActiveScene().buildIndex == 3){
            filePath = Application.persistentDataPath + "/times_2.txt";

        }
        // Path to the file where the times will be saved
        //string filePath = Application.persistentDataPath + "/times.txt";

        // Read existing times from the file
        List<string> times = new List<string>();
        if (File.Exists(filePath))
        {
            times = File.ReadAllLines(filePath).ToList();
        }

        // Add the new time to the list
        times.Add(timeString);

        // Sort the times and keep only the 5 best
        times = times.OrderBy(time => ParseTime(time)).Take(5).ToList();

        // Write the times back to the file
        File.WriteAllLines(filePath, times);
    }

    private TimeSpan ParseTime(string timeString)
    {
        DateTime dateTime = DateTime.ParseExact(timeString, "mm:ss.ff", System.Globalization.CultureInfo.InvariantCulture);
        return dateTime.TimeOfDay;
    }

}
