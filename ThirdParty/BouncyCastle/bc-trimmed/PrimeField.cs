﻿//***********************************************************************************************
//
// This file was imported from the C# Bouncy Castle project. Original license header is retained:
//
//
// The Bouncy Castle Cryptographic C#® API
//
// License:
// 
// The Bouncy Castle License
// Copyright (c) 2000-2014 The Legion of the Bouncy Castle Inc. (http://www.bouncycastle.org)
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software
// and associated documentation files (the "Software"), to deal in the Software without restriction,
// including without limitation the rights to use, copy, modify, merge, publish, distribute,
// sub license, and/or sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or
// substantial portions of the Software.
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
// PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
//
//***********************************************************************************************

using System;

namespace Org.BouncyCastle.Math.Field
{
    internal class PrimeField
        : IFiniteField
    {
        protected readonly BigInteger characteristic;

        internal PrimeField(BigInteger characteristic)
        {
            this.characteristic = characteristic;
        }

        public virtual BigInteger Characteristic
        {
            get { return characteristic; }
        }

        public virtual int Dimension
        {
            get { return 1; }
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }
            PrimeField other = obj as PrimeField;
            if (null == other)
            {
                return false;
            }
            return characteristic.Equals(other.characteristic);
        }

        public override int GetHashCode()
        {
            return characteristic.GetHashCode();
        }
    }
}
