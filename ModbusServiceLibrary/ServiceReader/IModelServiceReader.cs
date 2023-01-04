﻿using System.Collections.Generic;
using ModbusServiceLibrary.Model.RTU;
using ModbusServiceLibrary.Model.SignalMapping;

namespace ModbusServiceLibrary.ServiceReader
{
	public interface IModelServiceReader
	{
		/// <summary>
		/// Reads all RTUs
		/// </summary>
		/// <returns>List of RTUs</returns>
		List<RTU> ReadAllRTUs();

		/// <summary>
		/// Reads all analog signal mappings from model service
		/// </summary>
		/// <returns>List of analog signal mappings</returns>
		List<AnalogSignalMapping> ReadAnalogSignalMappings();

		/// <summary>
		/// Reads all discrete signal mappings from model service
		/// </summary>
		/// <returns>List of discrete signal mappings</returns>
		List<DiscreteSignalMapping> ReadDiscreteSignalMappings();
	}
}