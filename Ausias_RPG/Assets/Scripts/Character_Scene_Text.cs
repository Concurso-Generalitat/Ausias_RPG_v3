using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Character_Scene_Text : MonoBehaviour {

    public Text message;
    private string message1;

    private int ticks;
    public int tick_rate = 4;
    private int len;
    private int counter;


    void Start()
    {
        message = GetComponent<Text>();
        message1 = "Ausias, no puc acabar la guia de la Vall d'Aran sol. Necessito la teva ajuda. Agafa la meva camera.               (Prem F)"; // 102
        ticks = counter = 0;
        len = 122;
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (counter < len)
        {
            ticks++;

            if (ticks % tick_rate == 0)
            {
                message.text += "" + message1[counter];
                counter++;
            }
        }
        else
        {
            if(Input.GetKeyUp(KeyCode.F))
            {
                Application.LoadLevel(2);
            }
        }


    }
	    
}
