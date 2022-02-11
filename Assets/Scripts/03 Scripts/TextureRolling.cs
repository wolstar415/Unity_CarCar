using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureRolling : MonoBehaviour

{
    public float RollingSpeed;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float offest = Time.time * RollingSpeed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(0, -offest));
    }
}
