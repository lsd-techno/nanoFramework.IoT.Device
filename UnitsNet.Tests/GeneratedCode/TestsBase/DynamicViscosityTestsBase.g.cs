//------------------------------------------------------------------------------
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
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of DynamicViscosity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class DynamicViscosityTestsBase : QuantityTestsBase
    {
        protected abstract double CentipoiseInOneNewtonSecondPerMeterSquared { get; }
        protected abstract double MicropascalSecondsInOneNewtonSecondPerMeterSquared { get; }
        protected abstract double MillipascalSecondsInOneNewtonSecondPerMeterSquared { get; }
        protected abstract double NewtonSecondsPerMeterSquaredInOneNewtonSecondPerMeterSquared { get; }
        protected abstract double PascalSecondsInOneNewtonSecondPerMeterSquared { get; }
        protected abstract double PoiseInOneNewtonSecondPerMeterSquared { get; }
        protected abstract double PoundsForceSecondPerSquareFootInOneNewtonSecondPerMeterSquared { get; }
        protected abstract double PoundsForceSecondPerSquareInchInOneNewtonSecondPerMeterSquared { get; }
        protected abstract double PoundsPerFootSecondInOneNewtonSecondPerMeterSquared { get; }
        protected abstract double ReynsInOneNewtonSecondPerMeterSquared { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentipoiseTolerance { get { return 1e-5; } }
        protected virtual double MicropascalSecondsTolerance { get { return 1e-5; } }
        protected virtual double MillipascalSecondsTolerance { get { return 1e-5; } }
        protected virtual double NewtonSecondsPerMeterSquaredTolerance { get { return 1e-5; } }
        protected virtual double PascalSecondsTolerance { get { return 1e-5; } }
        protected virtual double PoiseTolerance { get { return 1e-5; } }
        protected virtual double PoundsForceSecondPerSquareFootTolerance { get { return 1e-5; } }
        protected virtual double PoundsForceSecondPerSquareInchTolerance { get { return 1e-5; } }
        protected virtual double PoundsPerFootSecondTolerance { get { return 1e-5; } }
        protected virtual double ReynsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new DynamicViscosity((double)0.0, DynamicViscosityUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new DynamicViscosity();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(DynamicViscosityUnit.NewtonSecondPerMeterSquared, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new DynamicViscosity(double.PositiveInfinity, DynamicViscosityUnit.NewtonSecondPerMeterSquared));
            Assert.Throws<ArgumentException>(() => new DynamicViscosity(double.NegativeInfinity, DynamicViscosityUnit.NewtonSecondPerMeterSquared));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new DynamicViscosity(double.NaN, DynamicViscosityUnit.NewtonSecondPerMeterSquared));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new DynamicViscosity(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new DynamicViscosity(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (DynamicViscosity) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void DynamicViscosity_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new DynamicViscosity(1, DynamicViscosityUnit.NewtonSecondPerMeterSquared);

            QuantityInfo<DynamicViscosityUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(DynamicViscosity.Zero, quantityInfo.Zero);
            Assert.Equal("DynamicViscosity", quantityInfo.Name);
            Assert.Equal(QuantityType.DynamicViscosity, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<DynamicViscosityUnit>().Except(new[] {DynamicViscosityUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
        }

        [Fact]
        public void NewtonSecondPerMeterSquaredToDynamicViscosityUnits()
        {
            DynamicViscosity newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            AssertEx.EqualTolerance(CentipoiseInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.Centipoise, CentipoiseTolerance);
            AssertEx.EqualTolerance(MicropascalSecondsInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.MicropascalSeconds, MicropascalSecondsTolerance);
            AssertEx.EqualTolerance(MillipascalSecondsInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.MillipascalSeconds, MillipascalSecondsTolerance);
            AssertEx.EqualTolerance(NewtonSecondsPerMeterSquaredInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(PascalSecondsInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.PascalSeconds, PascalSecondsTolerance);
            AssertEx.EqualTolerance(PoiseInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.Poise, PoiseTolerance);
            AssertEx.EqualTolerance(PoundsForceSecondPerSquareFootInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.PoundsForceSecondPerSquareFoot, PoundsForceSecondPerSquareFootTolerance);
            AssertEx.EqualTolerance(PoundsForceSecondPerSquareInchInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.PoundsForceSecondPerSquareInch, PoundsForceSecondPerSquareInchTolerance);
            AssertEx.EqualTolerance(PoundsPerFootSecondInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.PoundsPerFootSecond, PoundsPerFootSecondTolerance);
            AssertEx.EqualTolerance(ReynsInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.Reyns, ReynsTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = DynamicViscosity.From(1, DynamicViscosityUnit.Centipoise);
            AssertEx.EqualTolerance(1, quantity00.Centipoise, CentipoiseTolerance);
            Assert.Equal(DynamicViscosityUnit.Centipoise, quantity00.Unit);

            var quantity01 = DynamicViscosity.From(1, DynamicViscosityUnit.MicropascalSecond);
            AssertEx.EqualTolerance(1, quantity01.MicropascalSeconds, MicropascalSecondsTolerance);
            Assert.Equal(DynamicViscosityUnit.MicropascalSecond, quantity01.Unit);

            var quantity02 = DynamicViscosity.From(1, DynamicViscosityUnit.MillipascalSecond);
            AssertEx.EqualTolerance(1, quantity02.MillipascalSeconds, MillipascalSecondsTolerance);
            Assert.Equal(DynamicViscosityUnit.MillipascalSecond, quantity02.Unit);

            var quantity03 = DynamicViscosity.From(1, DynamicViscosityUnit.NewtonSecondPerMeterSquared);
            AssertEx.EqualTolerance(1, quantity03.NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            Assert.Equal(DynamicViscosityUnit.NewtonSecondPerMeterSquared, quantity03.Unit);

            var quantity04 = DynamicViscosity.From(1, DynamicViscosityUnit.PascalSecond);
            AssertEx.EqualTolerance(1, quantity04.PascalSeconds, PascalSecondsTolerance);
            Assert.Equal(DynamicViscosityUnit.PascalSecond, quantity04.Unit);

            var quantity05 = DynamicViscosity.From(1, DynamicViscosityUnit.Poise);
            AssertEx.EqualTolerance(1, quantity05.Poise, PoiseTolerance);
            Assert.Equal(DynamicViscosityUnit.Poise, quantity05.Unit);

            var quantity06 = DynamicViscosity.From(1, DynamicViscosityUnit.PoundForceSecondPerSquareFoot);
            AssertEx.EqualTolerance(1, quantity06.PoundsForceSecondPerSquareFoot, PoundsForceSecondPerSquareFootTolerance);
            Assert.Equal(DynamicViscosityUnit.PoundForceSecondPerSquareFoot, quantity06.Unit);

            var quantity07 = DynamicViscosity.From(1, DynamicViscosityUnit.PoundForceSecondPerSquareInch);
            AssertEx.EqualTolerance(1, quantity07.PoundsForceSecondPerSquareInch, PoundsForceSecondPerSquareInchTolerance);
            Assert.Equal(DynamicViscosityUnit.PoundForceSecondPerSquareInch, quantity07.Unit);

            var quantity08 = DynamicViscosity.From(1, DynamicViscosityUnit.PoundPerFootSecond);
            AssertEx.EqualTolerance(1, quantity08.PoundsPerFootSecond, PoundsPerFootSecondTolerance);
            Assert.Equal(DynamicViscosityUnit.PoundPerFootSecond, quantity08.Unit);

            var quantity09 = DynamicViscosity.From(1, DynamicViscosityUnit.Reyn);
            AssertEx.EqualTolerance(1, quantity09.Reyns, ReynsTolerance);
            Assert.Equal(DynamicViscosityUnit.Reyn, quantity09.Unit);

        }

        [Fact]
        public void FromNewtonSecondsPerMeterSquared_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => DynamicViscosity.FromNewtonSecondsPerMeterSquared(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => DynamicViscosity.FromNewtonSecondsPerMeterSquared(double.NegativeInfinity));
        }

        [Fact]
        public void FromNewtonSecondsPerMeterSquared_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => DynamicViscosity.FromNewtonSecondsPerMeterSquared(double.NaN));
        }

        [Fact]
        public void As()
        {
            var newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            AssertEx.EqualTolerance(CentipoiseInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.As(DynamicViscosityUnit.Centipoise), CentipoiseTolerance);
            AssertEx.EqualTolerance(MicropascalSecondsInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.As(DynamicViscosityUnit.MicropascalSecond), MicropascalSecondsTolerance);
            AssertEx.EqualTolerance(MillipascalSecondsInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.As(DynamicViscosityUnit.MillipascalSecond), MillipascalSecondsTolerance);
            AssertEx.EqualTolerance(NewtonSecondsPerMeterSquaredInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.As(DynamicViscosityUnit.NewtonSecondPerMeterSquared), NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(PascalSecondsInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.As(DynamicViscosityUnit.PascalSecond), PascalSecondsTolerance);
            AssertEx.EqualTolerance(PoiseInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.As(DynamicViscosityUnit.Poise), PoiseTolerance);
            AssertEx.EqualTolerance(PoundsForceSecondPerSquareFootInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.As(DynamicViscosityUnit.PoundForceSecondPerSquareFoot), PoundsForceSecondPerSquareFootTolerance);
            AssertEx.EqualTolerance(PoundsForceSecondPerSquareInchInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.As(DynamicViscosityUnit.PoundForceSecondPerSquareInch), PoundsForceSecondPerSquareInchTolerance);
            AssertEx.EqualTolerance(PoundsPerFootSecondInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.As(DynamicViscosityUnit.PoundPerFootSecond), PoundsPerFootSecondTolerance);
            AssertEx.EqualTolerance(ReynsInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.As(DynamicViscosityUnit.Reyn), ReynsTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new DynamicViscosity(value: 1, unit: DynamicViscosity.BaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = (double) AsWithSIUnitSystem();
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Fact]
        public void ToUnit()
        {
            var newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);

            var centipoiseQuantity = newtonsecondpermetersquared.ToUnit(DynamicViscosityUnit.Centipoise);
            AssertEx.EqualTolerance(CentipoiseInOneNewtonSecondPerMeterSquared, (double)centipoiseQuantity.Value, CentipoiseTolerance);
            Assert.Equal(DynamicViscosityUnit.Centipoise, centipoiseQuantity.Unit);

            var micropascalsecondQuantity = newtonsecondpermetersquared.ToUnit(DynamicViscosityUnit.MicropascalSecond);
            AssertEx.EqualTolerance(MicropascalSecondsInOneNewtonSecondPerMeterSquared, (double)micropascalsecondQuantity.Value, MicropascalSecondsTolerance);
            Assert.Equal(DynamicViscosityUnit.MicropascalSecond, micropascalsecondQuantity.Unit);

            var millipascalsecondQuantity = newtonsecondpermetersquared.ToUnit(DynamicViscosityUnit.MillipascalSecond);
            AssertEx.EqualTolerance(MillipascalSecondsInOneNewtonSecondPerMeterSquared, (double)millipascalsecondQuantity.Value, MillipascalSecondsTolerance);
            Assert.Equal(DynamicViscosityUnit.MillipascalSecond, millipascalsecondQuantity.Unit);

            var newtonsecondpermetersquaredQuantity = newtonsecondpermetersquared.ToUnit(DynamicViscosityUnit.NewtonSecondPerMeterSquared);
            AssertEx.EqualTolerance(NewtonSecondsPerMeterSquaredInOneNewtonSecondPerMeterSquared, (double)newtonsecondpermetersquaredQuantity.Value, NewtonSecondsPerMeterSquaredTolerance);
            Assert.Equal(DynamicViscosityUnit.NewtonSecondPerMeterSquared, newtonsecondpermetersquaredQuantity.Unit);

            var pascalsecondQuantity = newtonsecondpermetersquared.ToUnit(DynamicViscosityUnit.PascalSecond);
            AssertEx.EqualTolerance(PascalSecondsInOneNewtonSecondPerMeterSquared, (double)pascalsecondQuantity.Value, PascalSecondsTolerance);
            Assert.Equal(DynamicViscosityUnit.PascalSecond, pascalsecondQuantity.Unit);

            var poiseQuantity = newtonsecondpermetersquared.ToUnit(DynamicViscosityUnit.Poise);
            AssertEx.EqualTolerance(PoiseInOneNewtonSecondPerMeterSquared, (double)poiseQuantity.Value, PoiseTolerance);
            Assert.Equal(DynamicViscosityUnit.Poise, poiseQuantity.Unit);

            var poundforcesecondpersquarefootQuantity = newtonsecondpermetersquared.ToUnit(DynamicViscosityUnit.PoundForceSecondPerSquareFoot);
            AssertEx.EqualTolerance(PoundsForceSecondPerSquareFootInOneNewtonSecondPerMeterSquared, (double)poundforcesecondpersquarefootQuantity.Value, PoundsForceSecondPerSquareFootTolerance);
            Assert.Equal(DynamicViscosityUnit.PoundForceSecondPerSquareFoot, poundforcesecondpersquarefootQuantity.Unit);

            var poundforcesecondpersquareinchQuantity = newtonsecondpermetersquared.ToUnit(DynamicViscosityUnit.PoundForceSecondPerSquareInch);
            AssertEx.EqualTolerance(PoundsForceSecondPerSquareInchInOneNewtonSecondPerMeterSquared, (double)poundforcesecondpersquareinchQuantity.Value, PoundsForceSecondPerSquareInchTolerance);
            Assert.Equal(DynamicViscosityUnit.PoundForceSecondPerSquareInch, poundforcesecondpersquareinchQuantity.Unit);

            var poundperfootsecondQuantity = newtonsecondpermetersquared.ToUnit(DynamicViscosityUnit.PoundPerFootSecond);
            AssertEx.EqualTolerance(PoundsPerFootSecondInOneNewtonSecondPerMeterSquared, (double)poundperfootsecondQuantity.Value, PoundsPerFootSecondTolerance);
            Assert.Equal(DynamicViscosityUnit.PoundPerFootSecond, poundperfootsecondQuantity.Unit);

            var reynQuantity = newtonsecondpermetersquared.ToUnit(DynamicViscosityUnit.Reyn);
            AssertEx.EqualTolerance(ReynsInOneNewtonSecondPerMeterSquared, (double)reynQuantity.Value, ReynsTolerance);
            Assert.Equal(DynamicViscosityUnit.Reyn, reynQuantity.Unit);
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1).ToBaseUnit();
            Assert.Equal(DynamicViscosity.BaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            DynamicViscosity newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            AssertEx.EqualTolerance(1, DynamicViscosity.FromCentipoise(newtonsecondpermetersquared.Centipoise).NewtonSecondsPerMeterSquared, CentipoiseTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.FromMicropascalSeconds(newtonsecondpermetersquared.MicropascalSeconds).NewtonSecondsPerMeterSquared, MicropascalSecondsTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.FromMillipascalSeconds(newtonsecondpermetersquared.MillipascalSeconds).NewtonSecondsPerMeterSquared, MillipascalSecondsTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.FromNewtonSecondsPerMeterSquared(newtonsecondpermetersquared.NewtonSecondsPerMeterSquared).NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.FromPascalSeconds(newtonsecondpermetersquared.PascalSeconds).NewtonSecondsPerMeterSquared, PascalSecondsTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.FromPoise(newtonsecondpermetersquared.Poise).NewtonSecondsPerMeterSquared, PoiseTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.FromPoundsForceSecondPerSquareFoot(newtonsecondpermetersquared.PoundsForceSecondPerSquareFoot).NewtonSecondsPerMeterSquared, PoundsForceSecondPerSquareFootTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.FromPoundsForceSecondPerSquareInch(newtonsecondpermetersquared.PoundsForceSecondPerSquareInch).NewtonSecondsPerMeterSquared, PoundsForceSecondPerSquareInchTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.FromPoundsPerFootSecond(newtonsecondpermetersquared.PoundsPerFootSecond).NewtonSecondsPerMeterSquared, PoundsPerFootSecondTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.FromReyns(newtonsecondpermetersquared.Reyns).NewtonSecondsPerMeterSquared, ReynsTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            DynamicViscosity v = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            AssertEx.EqualTolerance(-1, -v.NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(2, (DynamicViscosity.FromNewtonSecondsPerMeterSquared(3)-v).NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(2, (v + v).NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(10, (v*10).NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(10, (10*v).NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(2, (DynamicViscosity.FromNewtonSecondsPerMeterSquared(10)/5).NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(2, DynamicViscosity.FromNewtonSecondsPerMeterSquared(10)/DynamicViscosity.FromNewtonSecondsPerMeterSquared(5), NewtonSecondsPerMeterSquaredTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            DynamicViscosity oneNewtonSecondPerMeterSquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            DynamicViscosity twoNewtonSecondsPerMeterSquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(2);

            Assert.True(oneNewtonSecondPerMeterSquared < twoNewtonSecondsPerMeterSquared);
            Assert.True(oneNewtonSecondPerMeterSquared <= twoNewtonSecondsPerMeterSquared);
            Assert.True(twoNewtonSecondsPerMeterSquared > oneNewtonSecondPerMeterSquared);
            Assert.True(twoNewtonSecondsPerMeterSquared >= oneNewtonSecondPerMeterSquared);

            Assert.False(oneNewtonSecondPerMeterSquared > twoNewtonSecondsPerMeterSquared);
            Assert.False(oneNewtonSecondPerMeterSquared >= twoNewtonSecondsPerMeterSquared);
            Assert.False(twoNewtonSecondsPerMeterSquared < oneNewtonSecondPerMeterSquared);
            Assert.False(twoNewtonSecondsPerMeterSquared <= oneNewtonSecondPerMeterSquared);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            DynamicViscosity newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            Assert.Equal(0, newtonsecondpermetersquared.CompareTo(newtonsecondpermetersquared));
            Assert.True(newtonsecondpermetersquared.CompareTo(DynamicViscosity.Zero) > 0);
            Assert.True(DynamicViscosity.Zero.CompareTo(newtonsecondpermetersquared) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            DynamicViscosity newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            Assert.Throws<ArgumentException>(() => newtonsecondpermetersquared.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            DynamicViscosity newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            Assert.Throws<ArgumentNullException>(() => newtonsecondpermetersquared.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            var b = DynamicViscosity.FromNewtonSecondsPerMeterSquared(2);

#pragma warning disable CS8073
// ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
#pragma warning restore CS8073
        }

        [Fact]
        public void Equals_SameType_IsImplemented()
        {
            var a = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            var b = DynamicViscosity.FromNewtonSecondsPerMeterSquared(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            object b = DynamicViscosity.FromNewtonSecondsPerMeterSquared(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            Assert.True(v.Equals(DynamicViscosity.FromNewtonSecondsPerMeterSquared(1), NewtonSecondsPerMeterSquaredTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(DynamicViscosity.Zero, NewtonSecondsPerMeterSquaredTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(DynamicViscosity.FromNewtonSecondsPerMeterSquared(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            DynamicViscosity newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            Assert.False(newtonsecondpermetersquared.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            DynamicViscosity newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            Assert.False(newtonsecondpermetersquared.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(DynamicViscosityUnit.Undefined, DynamicViscosity.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(DynamicViscosityUnit)).Cast<DynamicViscosityUnit>();
            foreach(var unit in units)
            {
                if(unit == DynamicViscosityUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(DynamicViscosity.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 cP", new DynamicViscosity(1, DynamicViscosityUnit.Centipoise).ToString());
                Assert.Equal("1 µPa·s", new DynamicViscosity(1, DynamicViscosityUnit.MicropascalSecond).ToString());
                Assert.Equal("1 mPa·s", new DynamicViscosity(1, DynamicViscosityUnit.MillipascalSecond).ToString());
                Assert.Equal("1 Ns/m²", new DynamicViscosity(1, DynamicViscosityUnit.NewtonSecondPerMeterSquared).ToString());
                Assert.Equal("1 Pa·s", new DynamicViscosity(1, DynamicViscosityUnit.PascalSecond).ToString());
                Assert.Equal("1 P", new DynamicViscosity(1, DynamicViscosityUnit.Poise).ToString());
                Assert.Equal("1 lbf·s/ft²", new DynamicViscosity(1, DynamicViscosityUnit.PoundForceSecondPerSquareFoot).ToString());
                Assert.Equal("1 lbf·s/in²", new DynamicViscosity(1, DynamicViscosityUnit.PoundForceSecondPerSquareInch).ToString());
                Assert.Equal("1 lb/ft·s", new DynamicViscosity(1, DynamicViscosityUnit.PoundPerFootSecond).ToString());
                Assert.Equal("1 reyn", new DynamicViscosity(1, DynamicViscosityUnit.Reyn).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 cP", new DynamicViscosity(1, DynamicViscosityUnit.Centipoise).ToString(swedishCulture));
            Assert.Equal("1 µPa·s", new DynamicViscosity(1, DynamicViscosityUnit.MicropascalSecond).ToString(swedishCulture));
            Assert.Equal("1 mPa·s", new DynamicViscosity(1, DynamicViscosityUnit.MillipascalSecond).ToString(swedishCulture));
            Assert.Equal("1 Ns/m²", new DynamicViscosity(1, DynamicViscosityUnit.NewtonSecondPerMeterSquared).ToString(swedishCulture));
            Assert.Equal("1 Pa·s", new DynamicViscosity(1, DynamicViscosityUnit.PascalSecond).ToString(swedishCulture));
            Assert.Equal("1 P", new DynamicViscosity(1, DynamicViscosityUnit.Poise).ToString(swedishCulture));
            Assert.Equal("1 lbf·s/ft²", new DynamicViscosity(1, DynamicViscosityUnit.PoundForceSecondPerSquareFoot).ToString(swedishCulture));
            Assert.Equal("1 lbf·s/in²", new DynamicViscosity(1, DynamicViscosityUnit.PoundForceSecondPerSquareInch).ToString(swedishCulture));
            Assert.Equal("1 lb/ft·s", new DynamicViscosity(1, DynamicViscosityUnit.PoundPerFootSecond).ToString(swedishCulture));
            Assert.Equal("1 reyn", new DynamicViscosity(1, DynamicViscosityUnit.Reyn).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 Ns/m²", new DynamicViscosity(0.123456, DynamicViscosityUnit.NewtonSecondPerMeterSquared).ToString("s1"));
                Assert.Equal("0.12 Ns/m²", new DynamicViscosity(0.123456, DynamicViscosityUnit.NewtonSecondPerMeterSquared).ToString("s2"));
                Assert.Equal("0.123 Ns/m²", new DynamicViscosity(0.123456, DynamicViscosityUnit.NewtonSecondPerMeterSquared).ToString("s3"));
                Assert.Equal("0.1235 Ns/m²", new DynamicViscosity(0.123456, DynamicViscosityUnit.NewtonSecondPerMeterSquared).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 Ns/m²", new DynamicViscosity(0.123456, DynamicViscosityUnit.NewtonSecondPerMeterSquared).ToString("s1", culture));
            Assert.Equal("0.12 Ns/m²", new DynamicViscosity(0.123456, DynamicViscosityUnit.NewtonSecondPerMeterSquared).ToString("s2", culture));
            Assert.Equal("0.123 Ns/m²", new DynamicViscosity(0.123456, DynamicViscosityUnit.NewtonSecondPerMeterSquared).ToString("s3", culture));
            Assert.Equal("0.1235 Ns/m²", new DynamicViscosity(0.123456, DynamicViscosityUnit.NewtonSecondPerMeterSquared).ToString("s4", culture));
        }


        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }


        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(DynamicViscosity)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(DynamicViscosityUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1.0);
            Assert.Equal(QuantityType.DynamicViscosity, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1.0);
            Assert.Equal(DynamicViscosity.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1.0);
            Assert.Equal(DynamicViscosity.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1.0);
            Assert.Equal(new {DynamicViscosity.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(value);
            Assert.Equal(DynamicViscosity.FromNewtonSecondsPerMeterSquared(-value), -quantity);
        }
    }
}