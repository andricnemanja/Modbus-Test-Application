﻿using System.Runtime.Serialization;

namespace ModbusServiceLibrary.CommandResult
{
	[DataContract]
	public class ReadSingleAnalogSignalResult : CommandResultBase
	{
		[DataMember]
		public int SignalId { get; set; }
		[DataMember]
		public double SignalValue { get; set; }

		public ReadSingleAnalogSignalResult(int rtuId, int signalId, double signalValue) : base(rtuId)
		{
			SignalId = signalId;
			SignalValue = signalValue;
		}
	}
}
