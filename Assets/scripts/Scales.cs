using UnityEngine;

public class Scales : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _maxScale;

    private static int s_negativeOne = -1;

    private bool _isBigger;

    private Vector3 _scale;

    private void CheckNegativeEquls()
    {
        if (_speed < 0)
        {
            _speed *= s_negativeOne;
        }

        if (_maxScale < 1)
        {
            _maxScale *= s_negativeOne;
        }
    }

    private void TryScale()
    {
        if (_scale.x <= _maxScale && _isBigger == false)
        {
            _scale += new Vector3(_speed * Time.deltaTime, _speed * Time.deltaTime, _speed * Time.deltaTime);
        }
        else
        {
            _isBigger = true;
            _scale -= new Vector3(_speed * Time.deltaTime, _speed * Time.deltaTime, _speed * Time.deltaTime);
        }

        transform.localScale = _scale;

        if (_scale.x >= _maxScale || _scale.x <= 0)
        {
            _isBigger = !_isBigger;
        }
    }

    private void Update()
    {
        CheckNegativeEquls();
        TryScale();
    }
}
