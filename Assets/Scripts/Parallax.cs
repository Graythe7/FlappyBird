using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    // the Background picture is defined as a material which is a section in mesh renderer 
    private MeshRenderer meshRenderer;

    public float animationSpeed = 1f;


    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        // to access the offset to loop through the background 
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }
}
