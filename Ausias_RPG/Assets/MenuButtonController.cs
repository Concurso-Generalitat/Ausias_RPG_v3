using UnityEngine;
using System.Collections;

public class MenuButtonController : MonoBehaviour
{

    public GameObject Arrows;

    void OnMouseOver()
    {
        Arrows.SetActive(true);
    }
    void OnMouseExit()
    {
        Arrows.SetActive(false);
    }
}
