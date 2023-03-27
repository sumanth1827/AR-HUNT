using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    [SerializeField] private float _scrollSpeed = -5f;
    private Vector2 _startPos;
    public GameObject background;

    // Start is called before the first frame update
    void Start()
    {
        _startPos = background.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * _scrollSpeed, 10);
        transform.position = _startPos + Vector2.up * newPos;
    }
}
