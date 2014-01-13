/*****************************  NOTICE  ********************************************
* This file was autogenerated.  Do not edit.                                       *
* Instead, modify the schema in DataSchema related to this class and regenerate it *
***********************************************************************************/
using System;
using System.ComponentModel;
using WorldSmith.DataClasses.UI;
using WorldSmith.Panels;
using WorldSmith.Dialogs;

namespace WorldSmith.DataClasses
{
	class DotaUnit : DotaBaseUnit
	{
		[Category("General")]
		[Description("If this unit is an ancient unit or not.")]
		[DefaultValue(false)]
		public bool IsAncient
		{
			get;
			set;
		}

		[Category("General")]
		[Description("If this unit is neutral or not.")]
		[DefaultValue(false)]
		public bool IsNeutralUnitType
		{
			get;
			set;
		}

		[Category("Selection")]
		[Description("Units with the same selection group will cycle together when tabbing through owned units.")]
		[DefaultValue("")]
		public string SelectionGroup
		{
			get;
			set;
		}

		[Category("Selection")]
		[Description("Select this unit on spawn.")]
		[DefaultValue(false)]
		public bool SelectOnSpawn
		{
			get;
			set;
		}

		[Category("General")]
		[Description("Can this unit be dominated and controlled by players?")]
		[DefaultValue(false)]
		public bool CanBeDominated
		{
			get;
			set;
		}

		[Category("Selection")]
		[Description("No Description Set")]
		[DefaultValue(false)]
		public bool IgnoreAddSummonedToSelection
		{
			get;
			set;
		}

		[Category("Attack")]
		[Description("If this unit should auto-attack by default.")]
		[DefaultValue(true)]
		public bool AutoAttacksByDefault
		{
			get;
			set;
		}

		[Category("Attack")]
		[Description("No Description Set")]
		[DefaultValue(250)]
		public int AttackRangeBuffer
		{
			get;
			set;
		}

		[Category("Movement")]
		[Description("The distance at which this unit follows another. (?)")]
		[DefaultValue(100)]
		public int FollowRange
		{
			get;
			set;
		}

		[Category("Attack")]
		[Description("How much bots want to attack them vs other non-hero things")]
		[DefaultValue(1.0)]
		public float AttackDesire
		{
			get;
			set;
		}

		[Category("General")]
		[Description("If this unit wakes up neutrals when it gets close.")]
		[DefaultValue(true)]
		public bool WakesNeutrals
		{
			get;
			set;
		}

	}
}
