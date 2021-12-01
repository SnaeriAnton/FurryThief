using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(LockGenerateKernelsCod))]
public class LockOpener : MonoBehaviour
{
    [SerializeField] private Kernel[] _kernels;
    [SerializeField] private LockGenerateKernelsCod _lockRandomKernelCod;

    private int[] _numbers = new int[3];

    private bool _firstKernelOpened = false;
    private int _countOpenedKernel = 0;

    public event UnityAction BreakingDoor; 

    private void OnEnable()
    {
        _kernels = GetComponentsInChildren<Kernel>();

        foreach (var kernel in _kernels)
        {
            kernel.Unlocked += OnKernelUnblocked;
        }
    }

    private void OnDisable()
    {
        foreach (var kernel in _kernels)
        {
            kernel.Unlocked -= OnKernelUnblocked;
        }
    }

    private void Start()
    {
        GetLockCod(_lockRandomKernelCod.GenerateCod());

        for (int i = 0; i < _numbers.Length; i++)
        {
            Debug.Log(_numbers[i]);
        }
    }

    private void OnKernelUnblocked()
    {
        _countOpenedKernel += 1;
        if (_firstKernelOpened == true)
        {
            for (int i = 0; i < _countOpenedKernel; i++)
            {
                if (_kernels[_numbers[i]].Unblock == false)
                {
                    BlocKernels();
                    _countOpenedKernel = 0;
                    _firstKernelOpened = false;
                    return;
                }
            }

            foreach (var kernel in _kernels)
            {
                if (kernel.Unblock == false)
                {
                    return;
                }
            }
            BreakingDoor?.Invoke();
        }
        _firstKernelOpened = true;
    }

    private void GetLockCod(int[] _generaledCod)
    {
        for (int i = 0; i < _generaledCod.Length; i++)
        {
            _numbers[i] = _generaledCod[i];
        }
    }

    private void BlocKernels()
    {
        foreach (var kernel in _kernels)
        {
            kernel.Bloc();
        }
    }
}
