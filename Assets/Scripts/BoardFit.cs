using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[ExecuteInEditMode]
public class BoardFit : MonoBehaviour
{
    public float boardSpace = 4.3f;

    private void Update()
    {
        Camera.main.orthographicSize = boardSpace * Screen.height / Screen.width;
    }
}
