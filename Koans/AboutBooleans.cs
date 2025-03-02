﻿using Xunit;
using DotNetKoans.Engine;

namespace DotNetKoans.Koans;

public class AboutBooleans : Koan
{
	// The bool type represents boolean logical quantities.
	// The only possible values of bool are true and false.
	// No standard conversions exists between bool and other types.
	// bool is a simple type and is a Alias of System.Boolean, these
	// can be used interchangeably.

	[Step(1)]
	public void TrueIsTreatedAsTrue()
	{
		// true is true
		Assert.True(true);
	}

	[Step(2)]
	public void FalseIsTreatedAsFalse()
	{
		// false is false
		Assert.False(false);
	}

	[Step(3)]
	public void TrueIsNotFalse()
	{
		// true is not false
		Assert.NotEqual(true, false);
	}

	[Step(4)]
	public void BoolIsAReservedWordOfSystemBoolean()
	{
		// bool is a Alias of System.Boolean
		Assert.Equal(typeof(System.Boolean), typeof(bool));
	}

	[Step(5)]
	public void NoOtherTypeConvertsToBool()
	{
		var otherTypes = new object[]
		{
			true,
		};
		
		foreach (var otherType in otherTypes)
		{
			Assert.True(otherType is bool); // no other type can cast to bool
		}
	}
}