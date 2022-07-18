using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed : MonoBehaviour
{

    public bool Seed_Select;

    private void OnMouseUp()
    {
        Seed_Select = true;
    }
    private void OnMouseExit()
    {
        Seed_Select = false;
    }
}
