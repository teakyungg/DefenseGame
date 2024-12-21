using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill : MonoBehaviour
{
    [SerializeField] GameObject skillEffect;

    void Start()
    {
        GameObject arrow = Instantiate(skillEffect);
        arrow.name = "skill arrow";
        arrow.transform.position = new Vector3(0, 999, 0);
    }


}
