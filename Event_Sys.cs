using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event_Sys : MonoBehaviour
{
    [SerializeField] GameObject Pot;
    [SerializeField] GameObject Pot_A;
    [SerializeField] GameObject Pot_B;
    [SerializeField] GameObject Pot_C;

    [SerializeField] GameObject Seed_A;
    [SerializeField] GameObject Seed_B;
    [SerializeField] GameObject Seed_C;

    [SerializeField] GameObject Tool_A;
    [SerializeField] GameObject Tool_B;
    [SerializeField] GameObject Tool_C;
    [SerializeField] GameObject Tool_D;
    [SerializeField] GameObject Tool_E;

    [SerializeField] GameObject Info_UI;

    private bool Selected_Pot_A;
    private bool Selected_Pot_B;
    private bool Selected_Pot_C;

    private bool Selected_Seed_A;
    private bool Selected_Seed_B;
    private bool Selected_Seed_C;

    private bool Selected_Tool_A;
    private bool Selected_Tool_B;
    private bool Selected_Tool_C;
    private bool Selected_Tool_D;
    private bool Selected_Tool_E;

    public int Pot_1;
    public int Pot_2;
    public int Pot_3;

    private int A_Active;
    private int B_Active;
    private int C_Active;
    private int Active_check;

    public bool Activate = true;

    [SerializeField] GameObject Tool_UI;
    [SerializeField] GameObject Tool_Scene;
    public int Tool_num;

    private void Start()
    {
        Tool_UI.SetActive(false);
        Tool_Scene.SetActive(false);
    }

    private void Update()
    {
        Selected_Pot_A = Pot_A.GetComponent<Pot>().isSelected;
        Selected_Pot_B = Pot_B.GetComponent<Pot>().isSelected;
        Selected_Pot_C = Pot_C.GetComponent<Pot>().isSelected;

        Selected_Seed_A = Seed_A.GetComponent<Seed>().Seed_Select;
        Selected_Seed_B = Seed_B.GetComponent<Seed>().Seed_Select;
        Selected_Seed_C = Seed_C.GetComponent<Seed>().Seed_Select;

        Selected_Tool_A = Tool_A.GetComponent<Tool>().Tool_Select;
        Selected_Tool_B = Tool_B.GetComponent<Tool>().Tool_Select;
        Selected_Tool_C = Tool_C.GetComponent<Tool>().Tool_Select;
        Selected_Tool_D = Tool_D.GetComponent<Tool>().Tool_Select;
        Selected_Tool_E = Tool_E.GetComponent<Tool>().Tool_Select;

        if (Selected_Pot_A == true)
        {
            A_Active = 1;

            if (Selected_Seed_A == true)
            {
                Pot_1 = 1;
                Activate = false;
            }
            if (Selected_Seed_B == true)
            {
                Pot_1 = 2;
                Activate = false;
            }
            if (Selected_Seed_C == true)
            {
                Pot_1 = 3;
                Activate = false;
            }

            if (Selected_Tool_A == true)
            {
                Tool_num = 1;
                Activate = false;
                Tool_Active();
            }
            if (Selected_Tool_B == true)
            {
                Tool_num = 2;
                Activate = false;
                Tool_Active();
            }
            if (Selected_Tool_C == true)
            {
                Tool_num = 3;
                Activate = false;
                Tool_Active();
            }
            if (Selected_Tool_D == true)
            {
                Tool_num = 4;
                Activate = false;
                Tool_Active();
            }
            if (Selected_Tool_E == true)
            {
                Tool_num = 5;
                Activate = false;
                Tool_Active();
            }
        }
        if (Selected_Pot_B == true)
        {
            B_Active = 1;

            if (Selected_Seed_A == true)
            {
                Pot_2 = 1;
                Activate = false;
            }
            if (Selected_Seed_B == true)
            {
                Pot_2 = 2;
                Activate = false;
            }
            if (Selected_Seed_C == true)
            {
                Pot_2 = 3;
                Activate = false;
            }

            if (Selected_Tool_A == true)
            {
                Tool_num = 1;
                Activate = false;
                Tool_Active();
            }
            if (Selected_Tool_B == true)
            {
                Tool_num = 2;
                Activate = false;
                Tool_Active();
            }
            if (Selected_Tool_C == true)
            {
                Tool_num = 3;
                Activate = false;
                Tool_Active();
            }
            if (Selected_Tool_D == true)
            {
                Tool_num = 4;
                Activate = false;
                Tool_Active();
            }
            if (Selected_Tool_E == true)
            {
                Tool_num = 5;
                Activate = false;
                Tool_Active();
            }
        }
        if (Selected_Pot_C == true)
        {
            C_Active = 1;

            if (Selected_Seed_A == true)
            {
                Pot_3 = 1;
                Activate = false;
            }
            if (Selected_Seed_B == true)
            {
                Pot_3 = 2;
                Activate = false;
            }
            if (Selected_Seed_C == true)
            {
                Pot_3 = 3;
                Activate = false;
            }

            if (Selected_Tool_A == true)
            {
                Tool_num = 1;
                Activate = false;
                Tool_Active();
            }
            if (Selected_Tool_B == true)
            {
                Tool_num = 2;
                Activate = false;
                Tool_Active();
            }
            if (Selected_Tool_C == true)
            {
                Tool_num = 3;
                Activate = false;
                Tool_Active();
            }
            if (Selected_Tool_D == true)
            {
                Tool_num = 4;
                Activate = false;
                Tool_Active();
            }
            if (Selected_Tool_E == true)
            {
                Tool_num = 5;
                Activate = false;
                Tool_Active();
            }
        }


        //화분 중복 선택 방지
        Active_check = A_Active + B_Active + C_Active;
        if (Active_check > 1)
        {
            Activate = false;
        }

        if (Activate == false)
        {
            Invoke("Activate_Reset", 0.5f);
        }
    }

    private void Tool_Active()
    {
        Tool_UI.SetActive(true);
        Tool_Scene.SetActive(true);
        //Info_UI.SetActive(false);
        Pot.SetActive(false);
    }

    private void Activate_Reset()
    {
        Activate = true;
        A_Active = 0;
        B_Active = 0;
        C_Active = 0;
    }
}
