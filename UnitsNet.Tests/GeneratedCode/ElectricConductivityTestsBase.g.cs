﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ElectricConductivity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricConductivityTestsBase
    {
        protected abstract double SiemensPerMeterInOneSiemensPerMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double SiemensPerMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void SiemensPerMeterToElectricConductivityUnits()
        {
            ElectricConductivity siemenspermeter = ElectricConductivity.FromSiemensPerMeter(1);
            AssertEx.EqualTolerance(SiemensPerMeterInOneSiemensPerMeter, siemenspermeter.SiemensPerMeter, SiemensPerMeterTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ElectricConductivity.From(1, ElectricConductivityUnit.SiemensPerMeter).SiemensPerMeter, SiemensPerMeterTolerance);
        }

        [Fact]
        public void As()
        {
            var siemenspermeter = ElectricConductivity.FromSiemensPerMeter(1);
            AssertEx.EqualTolerance(SiemensPerMeterInOneSiemensPerMeter, siemenspermeter.As(ElectricConductivityUnit.SiemensPerMeter), SiemensPerMeterTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricConductivity siemenspermeter = ElectricConductivity.FromSiemensPerMeter(1);
            AssertEx.EqualTolerance(1, ElectricConductivity.FromSiemensPerMeter(siemenspermeter.SiemensPerMeter).SiemensPerMeter, SiemensPerMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricConductivity v = ElectricConductivity.FromSiemensPerMeter(1);
            AssertEx.EqualTolerance(-1, -v.SiemensPerMeter, SiemensPerMeterTolerance);
            AssertEx.EqualTolerance(2, (ElectricConductivity.FromSiemensPerMeter(3)-v).SiemensPerMeter, SiemensPerMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).SiemensPerMeter, SiemensPerMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).SiemensPerMeter, SiemensPerMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).SiemensPerMeter, SiemensPerMeterTolerance);
            AssertEx.EqualTolerance(2, (ElectricConductivity.FromSiemensPerMeter(10)/5).SiemensPerMeter, SiemensPerMeterTolerance);
            AssertEx.EqualTolerance(2, ElectricConductivity.FromSiemensPerMeter(10)/ElectricConductivity.FromSiemensPerMeter(5), SiemensPerMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricConductivity oneSiemensPerMeter = ElectricConductivity.FromSiemensPerMeter(1);
            ElectricConductivity twoSiemensPerMeter = ElectricConductivity.FromSiemensPerMeter(2);

            Assert.True(oneSiemensPerMeter < twoSiemensPerMeter);
            Assert.True(oneSiemensPerMeter <= twoSiemensPerMeter);
            Assert.True(twoSiemensPerMeter > oneSiemensPerMeter);
            Assert.True(twoSiemensPerMeter >= oneSiemensPerMeter);

            Assert.False(oneSiemensPerMeter > twoSiemensPerMeter);
            Assert.False(oneSiemensPerMeter >= twoSiemensPerMeter);
            Assert.False(twoSiemensPerMeter < oneSiemensPerMeter);
            Assert.False(twoSiemensPerMeter <= oneSiemensPerMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricConductivity siemenspermeter = ElectricConductivity.FromSiemensPerMeter(1);
            Assert.Equal(0, siemenspermeter.CompareTo(siemenspermeter));
            Assert.True(siemenspermeter.CompareTo(ElectricConductivity.Zero) > 0);
            Assert.True(ElectricConductivity.Zero.CompareTo(siemenspermeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricConductivity siemenspermeter = ElectricConductivity.FromSiemensPerMeter(1);
            Assert.Throws<ArgumentException>(() => siemenspermeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricConductivity siemenspermeter = ElectricConductivity.FromSiemensPerMeter(1);
            Assert.Throws<ArgumentNullException>(() => siemenspermeter.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            ElectricConductivity a = ElectricConductivity.FromSiemensPerMeter(1);
            ElectricConductivity b = ElectricConductivity.FromSiemensPerMeter(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            ElectricConductivity v = ElectricConductivity.FromSiemensPerMeter(1);
            Assert.True(v.Equals(ElectricConductivity.FromSiemensPerMeter(1), ElectricConductivity.FromSiemensPerMeter(SiemensPerMeterTolerance)));
            Assert.False(v.Equals(ElectricConductivity.Zero, ElectricConductivity.FromSiemensPerMeter(SiemensPerMeterTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricConductivity siemenspermeter = ElectricConductivity.FromSiemensPerMeter(1);
            Assert.False(siemenspermeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricConductivity siemenspermeter = ElectricConductivity.FromSiemensPerMeter(1);
            Assert.False(siemenspermeter.Equals(null));
        }
    }
}