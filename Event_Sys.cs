using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event_Sys : MonoBehaviour
{
    [SerializeField] GameObject Pot_A;
    [SerializeField] GameObject Pot_B;
    [SerializeField] GameObject Pot_C;

    [SerializeField] GameObject Seed_A;
    [SerializeField] GameObject Seed_B;
    [SerializeField] GameObject Seed_C;

    public bool Selected_Pot_A;
    public bool Selected_Pot_B;
    public bool Selected_Pot_C;
    public bool Selected_Seed_A;
    public bool Selected_Seed_B;
    public bool Selected_Seed_C;

    public int Pot_1;

    private void Update()
    {
        Selected_Pot_A = Pot_A.GetComponent<Pot>().isSelected;
        //Selected_Pot_B = Pot_B.GetComponent<Pot>().isSelected;
        //Selected_Pot_C = Pot_C.GetComponent<Pot>().isSelected;

        Selected_Seed_A = Seed_A.GetComponent<Seed>().Seed_Select;
        //Selected_Seed_B = Seed_B.GetComponent<Pot>().isSelected;
        //Selected_Seed_C = Seed_C.GetComponent<Pot>().isSelected;

        if (Selected_Pot_A == true)
        {
            if (Selected_Seed_A == true)
            {
                Pot_1 = 1;
            }
        }
    }
}
