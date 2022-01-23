using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePic : MonoBehaviour
{
    //Set these Textures in the Inspector
    Renderer m_Renderer;
    private Object[] textures;
    private int currSlide = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Fetch the Renderer from the GameObject
        m_Renderer = GetComponent<Renderer>();

        textures = Resources.LoadAll("Textures", typeof(Texture2D));

        //Set the Texture you assign in the Inspector as the main texture (Or Albedo)
        m_Renderer.material.SetTexture("_MainTex", (Texture2D)textures[0]);
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One) || OVRInput.GetDown(OVRInput.Button.Three))
        {
            currSlide++;
            if (currSlide >= textures.Length)
            {
                currSlide = 0;
            }
            m_Renderer.material.SetTexture("_MainTex", (Texture2D)textures[currSlide]);
        }

        if (OVRInput.GetDown(OVRInput.Button.Two) || OVRInput.GetDown(OVRInput.Button.Four))
        {
            currSlide--;
            if (currSlide < 0)
            {
                currSlide = textures.Length - 1;
            }
            m_Renderer.material.SetTexture("_MainTex", (Texture2D)textures[currSlide]);
        }
    }
}
