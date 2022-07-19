using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    [SerializeField] GameObject Pot;

    [SerializeField] Sprite Plant_A;
    [SerializeField] Sprite Plant_B;
    [SerializeField] Sprite Plant_C;

    private int Plant_Type;
    private SpriteRenderer Render;

    void Update()
    {
        Plant_Type = Pot.GetComponent<Pot>().Plant_Type;
        Render = this.GetComponent<SpriteRenderer>();
        if (Plant_Type > 0)
        {
            Sprite_Change();
        }
    }

    private void Sprite_Change()
    {
        if (Plant_Type == 1)
        {
            Render.sprite = Plant_A;
        }
        if (Plant_Type == 2)
        {
            Render.sprite = Plant_B;
        }
        if (Plant_Type == 3)
        {
            Render.sprite = Plant_C;
        }
    }
}
