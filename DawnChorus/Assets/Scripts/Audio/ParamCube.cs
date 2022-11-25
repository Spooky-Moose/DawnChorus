using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamCube : MonoBehaviour
{
    public int _band;
    public float _startScale, _maxScale, _scaleMultiplier;
    public bool _useBuffer;
    Material _material;

    // Start is called before the first frame update
    void Start()
    {
        _material = GetComponent<MeshRenderer>().materials[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (_useBuffer)
        {
           transform.localScale = new Vector3((AudioPeer._bandBuffer[_band] * _scaleMultiplier) + _startScale, transform.localScale.y , transform.localScale.z);
           transform.localScale = new Vector3((AudioPeer._audioBandBuffer[_band] * _maxScale) + _startScale, transform.localScale.y , transform.localScale.z);
            //Color _color = new Color(AudioPeer._audioBandBuffer[_band], AudioPeer._audioBandBuffer[_band], AudioPeer._audioBandBuffer[_band]);
            //_material.SetColor("_EmissionColor", _color);
        }

        if (!_useBuffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, (AudioPeer._freqBand[_band] * _scaleMultiplier) + _startScale, transform.localScale.z);
            transform.localScale = new Vector3(transform.localScale.x, (AudioPeer._audioBand[_band] * _maxScale) + _startScale, transform.localScale.z);
            //Color _color = new Color(AudioPeer._audioBand[_band], AudioPeer._audioBand[_band], AudioPeer._audioBand[_band]);
            //_material.SetColor("_EmissionColor", _color);
        }
    }
}