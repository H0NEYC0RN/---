using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seed : MonoBehaviour
{
    public bool Seed_Select;
    [SerializeField] int Seed_num;

    [SerializeField] Sprite Seed_A;
    [SerializeField] Sprite Seed_B;
    [SerializeField] Sprite Seed_C;
    [SerializeField] GameObject Info_UI;
    [SerializeField] Text Info_Text;

    private SpriteRenderer Render;

    private void Start()
    {
        Render = Info_UI.GetComponent<SpriteRenderer>();
    }

    private void OnMouseUp()
    {
        Seed_Select = true;
        Info_UI.SetActive(false);
        Info_Text.text = "";
        Invoke("Seed_Reset", 0.1f);
    }

    private void OnMouseEnter()
    {
        Info_UI.SetActive(true);

        if (Seed_num == 1)
        {
            Render.sprite = Seed_A;
            Info_Text.text = "씨앗 A";
        }
        if (Seed_num == 2)
        {
            Render.sprite = Seed_B;
            Info_Text.text = "씨앗 B";
        }
        if (Seed_num == 3)
        {
            Render.sprite = Seed_C;
            Info_Text.text = "씨앗 C";
        }
    }

    private void OnMouseExit()
    {
        Info_UI.SetActive(false);
        Info_Text.text = "";
    }

    private void Seed_Reset()
    {
        Seed_Select = false;
    }    
}
