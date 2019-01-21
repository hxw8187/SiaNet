﻿using System;
using System.Collections.Generic;
using System.Text;
using TensorSharp;
using TensorSharp.Expression;

namespace SiaNet.Layers.Activations
{
    public class Tanh : BaseLayer
    {
        public Tanh()
            : base("tanh")
        {
        }

        public override void Forward(Tensor x)
        {
            Input = x.ToParameter();
            Output = Tanh(x);
        }

        public override void Backward(Tensor outputgrad)
        {
            Input.Grad = outputgrad * (1 - Square(Output));
        }
    }
}
