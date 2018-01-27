using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour {

    private float lifeTime = 5f;
    private Material mat;
    private Color originalColor;
    private float fadePercent;
    private float deathTime;
    private bool fading;
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        Renderer renderer = GetComponent<Renderer>();
        mat = renderer.material;
        originalColor = mat.color;
        deathTime = Time.time + lifeTime;
        StartCoroutine(Fade());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Fade()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);

            if (fading)
            {
                fadePercent += Time.deltaTime;
                mat.color = Color.Lerp(originalColor, Color.clear, fadePercent);

                if (fadePercent <= 1)
                {
                    Destroy(gameObject);
                }
            }
            else
            {
                if (Time.time > deathTime)
                {
                    fading = true;
                }
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Ground"))
        {
            rb.Sleep();
        }
    }
}
