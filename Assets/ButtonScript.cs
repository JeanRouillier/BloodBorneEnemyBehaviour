using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonScript : MonoBehaviour
{
    public Text resultText;
    public Text historyText;

    private List<String> stackTemplate = new List<String>{"BASIC", "BASIC", "BASIC", "ABILITY", "SPECIAL", "SPECIAL"};
    private List<String> stack = new List<String>{"BASIC", "BASIC", "BASIC", "ABILITY", "SPECIAL", "SPECIAL"};
   

    public void draw(){
        int count = stack.Count;
        if(count == 0){
            shuffle();
        }
        System.Random rand = new System.Random();
        int index = rand.Next(count);
        resultText.text = stack[index];
        stack.RemoveAt(index);

        historyText.text = "Restantes: "+stack.Count;
    }

    public void shuffle(){
        stack = new List<string>(stackTemplate);
        historyText.text = "Restantes: "+stack.Count;
    }
}
