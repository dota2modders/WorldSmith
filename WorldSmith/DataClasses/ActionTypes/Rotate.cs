/*****************************  NOTICE  ********************************************
* This file was autogenerated.  Do not edit.                                       *
* Instead, modify the schema in DataSchema related to this class and regenerate it *
***********************************************************************************/
using System;
using System.ComponentModel;
using WorldSmith.Panels;
using WorldSmith.Dialogs;
using KVLib;

namespace WorldSmith.DataClasses
{
	[DotaAction]
	[EditorGrammar("Rotate %Target by %PitchYawRoll degrees")]
	public partial class Rotate : TargetedAction
	{
		public Rotate(KeyValue kv)
			: base(kv)
		{
		}
		public Rotate(string className)
			: base(className)
		{
		}
		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(NumberValue), "0 0 0")]
		public NumberValue PitchYawRoll
		{
			get
			{
				return default(NumberValue);
			}
			set
			{
				KeyValue kv = GetSubkey("PitchYawRoll");
				if(kv == null)
				{
					kv = new KeyValue("PitchYawRoll");
					KeyValue.AddChild(kv);
				}
				kv.Set(value.ToString());
			}
		}

	}
}
