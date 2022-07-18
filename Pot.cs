using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pot : MonoBehaviour
{
    [SerializeField] GameObject Seed;
    [SerializeField] GameObject Event;
    [SerializeField] GameObject Info_UI;
    [SerializeField] Text Info_Text;

    private SpriteRenderer render;
    public bool isSelected = false;
    public bool Gargening_Start;

    public int Plant_Type;
    //public int Pot_Type;
    //public int Growth_State;


    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        render.color = new Color(0, 0, 0);

        Info_UI.SetActive(false);
        Info_Text.text = "";

        Seed.SetActive(false);
    }

    private void Update()
    {
        if (this.tag == "Empty")
        {
            Plant_Type = Event.GetComponent<Event_Sys>().Pot_1;

            if (Plant_Type > 0)
            {
                this.tag = "Used";
                if (Gargening_Start == false)
                {
                    Seed.SetActive(false);
                    Info_UI.SetActive(false);
                    Info_Text.text = "";
                    Gargening_Start = true;
                }
            }

        }
    }

    private void OnMouseUp()
    {
        if (isSelected == false)
        {
            isSelected = true;
            render.color = new Color(0.7f, 0.7f, 0.7f);

            if (this.tag == "Empty")
            {
                Seed.SetActive(true);
            }
        }
        else
        {
            isSelected = false;
            Seed.SetActive(false);
        }
    }

    private void OnMouseEnter()
    {
        if (isSelected == false)
        {
            render.color = new Color(0.5f, 0.5f, 0.5f);
            Info_UI.SetActive(true);
            
            if (Plant_Type == 1)
            {
                Info_Text.text = "식물A";
            }
            else
            {
                Info_Text.text = "비어있는 화분";
            }
        }
    }

    private void OnMouseExit()
    {
        if (isSelected == false)
        {
            render.color = new Color(0, 0, 0);
            Info_UI.SetActive(false);
            Info_Text.text = "";
        }
    }
}
