using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour {

    public float scroll_Speed = 0.3f ;
    private MeshRenderer mesh_Renderer;
    
    void Awake()
    {
        mesh_Renderer = GetComponent<MeshRenderer>();
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Scroll();
	}
    void Scroll()
    {
        Vector2 offset = mesh_Renderer.sharedMaterial.GetTextureOffset("_MainTex");
        offset.y += Time.deltaTime * scroll_Speed;
        mesh_Renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
