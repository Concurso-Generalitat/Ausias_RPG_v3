using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Character_Scene_Text : MonoBehaviour
{
	private string[] message1 = new string[]{
		"Ausias, no puc acabar la guia de la Vall d'Aran sol. Necessito la teva ajuda. Agafa la meva camera.               (Prem F)", // 102
		"Ves a recollir la nova PLACA FOTOGRÀFICA que vaig encargar.               (Prem F)",
		"Oh! La campana de l'església no hi és. Pregumtem-li al monje on prodia estar.               (Prem F)",
		"Hi ha un carro enmig del camí. Anem a preguntar-li si podria moure-ho.               (Prem F)",
		"Se m’han volat les pàgines. Hem de trobar-les.               (Prem F)",
		"Perfecte, ja tenim les fotos de Viella. Anem a Salardú.               (Prem F)",
		"Molt bé, ja tenim les fotos de Salardú. Anem al Colomés.               (Prem F)",
		"Sense el carro les fotos queden increíbles. Anem a Artiés.               (Prem F)",
		"Ja tenim la Guia de la Vall d’Aran complerta. Gràcies per ajudarme.             (Prem F)",
		"M’acaba d’arribar la PLACA FOTOGRÁFICA que Juli Soler va encarregar.               (Prem F)",
		"El monje de Salardú necessita cola? Aquí la tens. Saluda-li de part meva.               (Prem F)",
		"La campana s’ha trencat. Podries ajudar-me a reparar-la?               (Prem F)",
		"Per arreglar la campana necesitem cola. Utilitza el mapa per anar a la botiga de Viella. Si em menciones et donarà la cola sense haber de pagarla.               (Prem F)",
		"Sabia que te la donaría. Ara la pujaré.               (Prem F)",
		"Per haber-me ajudat amb la campana, et donaré uns mistos.               (Prem F)",
		"Tenia pensat parar per menjar aquí. Si em portes un peix, mouré el carro. Toma la meva canya i intenta pescar un, cuina’l i emporame’l.               (Prem F)",
		"Gràcies per la teva ajuda. En seguida moc el carro.               (Prem F)",
		"He trobat una fulla abans. Probablement sigui el que estiguis buscant.               (Prem F)"};

	private Time time;
	private float fcounter;
    private int counter;
	private int len;

	public int TextNum = 0;
	public float textSpeed = 0.04f;

	private Text message;

    void Start()
    {
		message = this.gameObject.GetComponentInChildren<Text> ();

		counter = 0;
		len = message1 [TextNum].Length;
		fcounter = 0.0f;
    }
	
	void Update ()
    {
        if (counter < len)
        {
			if(Input.GetKeyUp(KeyCode.F))
			{
				message.text = message1[TextNum];
				counter = len;
			}
			
			float currentTime = Time.timeSinceLevelLoad;
			
			if (currentTime - fcounter >= textSpeed)
			{
				for(float i = 0.0f; i < currentTime - fcounter; i+=textSpeed)
				{
					if (counter < len)
					{
						message.text += "" + message1[TextNum][counter];
						counter++;
					}
				}
				
				fcounter = currentTime;
			}
        }
        else
        {
            if(Input.GetKeyUp(KeyCode.F))
            {
				GameObject ObjSceneManager = GameObject.Find("SceneManager");
				ObjSceneManager.GetComponent<SceneManager>().ReturnToPrevScene();
            }
        }
    }
	    
}
