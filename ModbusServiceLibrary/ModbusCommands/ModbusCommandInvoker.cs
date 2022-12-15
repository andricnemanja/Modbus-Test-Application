﻿using System.Collections.Generic;
using ModbusServiceLibrary.ModbusCommunication;

namespace ModbusServiceLibrary.ModbusCommands
{
	public sealed class ModbusCommandInvoker : IModbusCommandInvoker
	{
		private readonly IModbusConnection modbusConnection;

		public ModbusCommandInvoker(IModbusConnection modbusConnection)
		{
			this.modbusConnection = modbusConnection;
		}

		public Queue<ModbusCommand> Commands { get; set; } = new Queue<ModbusCommand>();

		public void WriteAnalogSignalValue(int rtuId, int signalAddress, int newValue)
		{
			ModbusCommand changeAnalogSignalCommand = new ChangeAnalogSignalValueCommand(modbusConnection, newValue, rtuId, signalAddress);
			changeAnalogSignalCommand.Execute();
			Commands.Enqueue(changeAnalogSignalCommand);
		}

		public void WriteDiscreteSignalValue(int rtuId, int signalAddress, bool newValue)
		{
			ModbusCommand changeAnalogSignalCommand = new ChangeDiscreteSignalValueCommand(modbusConnection, newValue, rtuId, signalAddress);
			changeAnalogSignalCommand.Execute();
			Commands.Enqueue(changeAnalogSignalCommand);
		}

		public int ReadAnalogSignalValue(int rtuId, int signalAddress)
		{
			ReadAnalogSignalValueCommand readAnalogSignalCommand = new ReadAnalogSignalValueCommand(modbusConnection, rtuId, signalAddress);
			readAnalogSignalCommand.Execute();
			Commands.Enqueue(readAnalogSignalCommand);

			return readAnalogSignalCommand.NewValue;
		}

		public bool ReadDiscreteSignalValue(int rtuId, int signalAddress)
		{
			ReadDiscreteSignalValueCommand readDiscreteSignalCommand = new ReadDiscreteSignalValueCommand(modbusConnection, rtuId, signalAddress);
			readDiscreteSignalCommand.Execute();
			Commands.Enqueue(readDiscreteSignalCommand);

			return readDiscreteSignalCommand.NewValue;
		}
	}
}
