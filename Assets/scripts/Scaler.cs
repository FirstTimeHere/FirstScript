using Unity.VisualScripting;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField][Range(0, 1000)] private float _speed;
    [SerializeField][Range(1, 1000)] private float _maxScale;

    private bool _isBigger;

    private Vector3 _scale;

    private void TryScale()
    {
        Vector3 _maxScaleVector = new Vector3(_maxScale, _maxScale, _maxScale);

        _scale = transform.localScale;

        if (_scale != _maxScaleVector && _isBigger == false)
        {
            transform.localScale = Vector3.MoveTowards(_scale, _maxScaleVector, _speed * Time.deltaTime);
        }
        else
        {
            transform.localScale = Vector3.MoveTowards(_scale, Vector3.one, _speed * Time.deltaTime);
            _isBigger = true;
        }

        if (_scale == Vector3.one && _isBigger)
        {
            _isBigger = !_isBigger;
        }
    }

    private void Update()
    {
        TryScale();
    }
}
