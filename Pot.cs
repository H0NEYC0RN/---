using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pot : MonoBehaviour
{
    [SerializeField] GameObject Seed;
    [SerializeField] GameObject Plant;
    [SerializeField] GameObject Gardening_tool;
    [SerializeField] GameObject Event;
    [SerializeField] GameObject Info_UI;
    [SerializeField] Text Info_Text;

    private SpriteRenderer Pot_render;
    private SpriteRenderer Plant_render;
    public bool isSelected = false;
    private bool Activate;

    [SerializeField] int Pot_num;
    public int Plant_Type;
    //public int Pot_Type;
    public int Growth_State;


    void Start()
    {
        Pot_render = GetComponent<SpriteRenderer>();
        Plant_render = Plant.GetComponent<SpriteRenderer>();
        Pot_render.color = new Color(0, 0, 0);

        Info_UI.SetActive(false);
        Info_Text.text = "";

        Seed.SetActive(false);
        Gardening_tool.SetActive(false);
        Plant.SetActive(false);
    }

    private void Update()
    {
        if (this.tag == "Empty")
        {
            if (Pot_num == 1)
            {
                Plant_Type = Event.GetComponent<Event_Sys>().Pot_1;
            }
            if (Pot_num == 2)
            {
                Plant_Type = Event.GetComponent<Event_Sys>().Pot_2;
            }
            if (Pot_num == 3)
            {
                Plant_Type = Event.GetComponent<Event_Sys>().Pot_3;
            }


            if (Plant_Type > 0)
            {
                
                if (Growth_State == 0)
                {
                    //Plant 의 종류를 반영하고 선택 초기화
                    Seed.SetActive(false);
                    Info_UI.SetActive(false);

                    Info_Text.text = "";
                    this.tag = "Used";

                    Pot_render.color = new Color(0, 0, 0);
                    Plant_render.color = new Color(1, 1, 1);

                    isSelected = false;
                    Growth_State = 1;

                    Plant.SetActive(true);
                }
            }

        }


        //중복 선택 방지용
        Activate = Event.GetComponent<Event_Sys>().Activate;
        if (Activate == false)
        {
            isSelected = false;
            Seed.SetActive(false);
            Gardening_tool.SetActive(false);

            Pot_render.color = new Color(0, 0, 0);
            Plant_render.color = new Color(1, 1, 1);
        }
    }

    private void OnMouseUp()
    {
        if (isSelected == false)
        {
            //화분을 선택하면 화분과 식물의 색을 바꿈
            isSelected = true;
            Pot_render.color = new Color(0.7f, 0.7f, 0.7f);
            Plant_render.color = new Color(0.7f, 0.7f, 0.7f);

            if (this.tag == "Empty")
            {
                Seed.SetActive(true);
                Info_UI.SetActive(false);
                Info_Text.text = "";
            }

            if (this.tag == "Used")
            {
                Gardening_tool.SetActive(true);
                Info_UI.SetActive(false);
                Info_Text.text = "";
            }

        }
        else
        {
            // 화분을 선택한 상태에서 다시 누르면 선택 초기화
            isSelected = false;
            Seed.SetActive(false);
            Gardening_tool.SetActive(false);
            Info_UI.SetActive(false);
            Info_Text.text = "";
        }
    }

    //화분에 마우스 커서를 올렸을 때 색상과 UI를 다르게 표시
    private void OnMouseOver()
    {
        if (isSelected == false)
        {
            Pot_render.color = new Color(0.5f, 0.5f, 0.5f);
            Plant_render.color = new Color(0.5f, 0.5f, 0.5f);
            Info_UI.SetActive(true);
            
            if (this.tag == "Used")
            {
                if (Plant_Type == 1)
                {
                    Info_Text.text = "식물A";
                }
                if (Plant_Type == 2)
                {
                    Info_Text.text = "식물B";
                }
                if (Plant_Type == 3)
                {
                    Info_Text.text = "식물C";
                }
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
            Pot_render.color = new Color(0, 0, 0);
            Plant_render.color = new Color(1, 1, 1);
            Info_UI.SetActive(false);
            Info_Text.text = "";
        }
    }
}