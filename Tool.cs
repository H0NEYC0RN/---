using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tool : MonoBehaviour
{
    public bool Tool_Select;
    [SerializeField] int Tool_num;

    [SerializeField] Sprite Tool_A;
    [SerializeField] Sprite Tool_B;
    [SerializeField] Sprite Tool_C;
    [SerializeField] Sprite Tool_D;
    [SerializeField] Sprite Tool_E;
    [SerializeField] GameObject Info_UI;
    [SerializeField] Text Info_Text;

    private SpriteRenderer Render;

    [SerializeField] GameObject Tools;

    private void Start()
    {
        Render = Info_UI.GetComponent<SpriteRenderer>();
    }

    private void OnMouseUp()
    {
        Tool_Select = true;
        Info_UI.SetActive(false);
        Info_Text.text = "";
        Invoke("Tool_Reset", 0.1f);
        Tools.SetActive(false);
    }

    private void OnMouseEnter()
    {
        Info_UI.SetActive(true);

        if (Tool_num == 1)
        {
            Render.sprite = Tool_A;
            Info_Text.text = "도구 A";
        }
        if (Tool_num == 2)
        {
            Render.sprite = Tool_B;
            Info_Text.text = "도구 B";
        }
        if (Tool_num == 3)
        {
            Render.sprite = Tool_C;
            Info_Text.text = "도구 C";
        }
        if (Tool_num == 4)
        {
            Render.sprite = Tool_D;
            Info_Text.text = "도구 D";
        }
        if (Tool_num == 5)
        {
            Render.sprite = Tool_E;
            Info_Text.text = "도구 E";
        }
    }

    private void OnMouseExit()
    {
        Info_UI.SetActive(false);
        Info_Text.text = "";
    }

    private void Tool_Reset()
    {
        Tool_Select = false;
    }
}
