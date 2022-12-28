using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity3DProjeRepository.Inputs
{
    public class DefaultInput 
    {
        DefaultAction _input;
        public bool IsFotceUp { get; private set; }
        public DefaultInput()
        {
            _input = new DefaultAction();
            //performed= performansýný gösterdiði ivent dir.
            // context anonim method dur.
            _input.Rocket.ForceUp.performed += context => IsFotceUp = context.ReadValueAsButton();
            _input.Enable();
        }
    }
}

