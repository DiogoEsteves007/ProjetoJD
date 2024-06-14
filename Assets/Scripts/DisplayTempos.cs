using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using UnityEngine.UI;

public class DisplayTempos : MonoBehaviour
{
     public Text times1Text; // Assign this in the Unity Inspector
    public Text times2Text; // Assign this in the Unity Inspector

    // Start is called before the first frame update
    void Start()
    {
        string filePath1 = Application.persistentDataPath + "/times_1.txt";
        string filePath2 = Application.persistentDataPath + "/times_2.txt";

        // Read and display the times
        DisplayTimesFromFile(filePath1, times1Text);
        DisplayTimesFromFile(filePath2, times2Text);
        
    }

   private void DisplayTimesFromFile(string filePath, Text displayText)
    {
        List<string> times = new List<string>();

        if (File.Exists(filePath))
        {
            times = File.ReadAllLines(filePath).ToList();
        }

        // Fill the rest of the list with "--" if there are less than 5 times
        while (times.Count < 5)
        {
            times.Add("--");
        }

        // Display the times in the Text component
        displayText.text = string.Join("\n", times);
    }
}
