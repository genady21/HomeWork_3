using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public enum Operation
{
    Plus,
    Minus,
    Mult,
    Div
}
public class Calc : MonoBehaviour
{
    [SerializeField] private Operation _operation;
    [SerializeField] private float _firstNumber;
    [SerializeField] private float _secondNumber;
    private float _result;
    [SerializeField] private bool _calculate = true;
    
    private float Plus()
    {
        Debug.Log("Сложение");
        return _secondNumber + _firstNumber;
    }
    private float Minus()
    {
        Debug.Log("Вычитание");
        return _firstNumber - _secondNumber;
    }
    private float Multi()
    {
        Debug.Log("Умножение");
        return _secondNumber * _firstNumber;
    }
    private float Div()
    {
        Debug.Log("Деление");
        if (_secondNumber == 0)
        {
            Debug.Log("Деление на 0 невозможно");
            return 0;
        }
        return _firstNumber / _secondNumber;
    }
    private void Calculate()
    {
        if (_calculate)
        {
            return;
        }
        switch (_operation)
        {
            case Operation.Plus:
                _result = Plus();
                break;
            case Operation.Minus:
                _result = Minus();
                break;
            case Operation.Mult:
                _result = Multi();
                break;
            case Operation.Div:
                _result = Div();
                break;
        }
        Debug.Log(_result);
        _calculate = true;
    }
    private void OnValidate()
    {
        Calculate();
    }
}
