using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity3DProjeRepository.Inputs
{
    public class DefaultInput 
    {
        DefaultAction _input;
        public bool IsForceUp { get; private set; }
        public DefaultInput()
        {
            _input = new DefaultAction();
          
            
            _input.Rocket.ForceUp.performed += context => IsForceUp = context.ReadValueAsButton();
            _input.Enable();
        }
    }
}

