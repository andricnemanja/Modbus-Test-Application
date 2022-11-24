﻿using Autofac;
using ModbusServiceLibrary;
using ModbusServiceLibrary.Data;
using ModbusServiceLibrary.ServiceReader;

namespace ModbusServiceHost
{
	/// <summary>
	/// Definining dependencies for Model Service classes
	/// </summary>
	public sealed class Bootstrapper
	{
		/// <summary>
		/// Create container that have all dependencies for Model Service classes
		/// </summary>
		public static ContainerBuilder RegisterContainerBuilder()
		{
			ContainerBuilder builder = new ContainerBuilder();

			builder.RegisterType<ModbusServiceLibrary.ModelServiceReference.ModelServiceClient>().As<ModbusServiceLibrary.ModelServiceReference.IModelService>();
			builder.RegisterType<ModelServiceReader>().As<IModelServiceReader>();
			builder.RegisterType<RtuStaticData>().As<IRtuStaticData>()
				.OnActivated(c => c.Instance.InitializeData());
			builder.RegisterType<ModbusService>().As<IModbusDuplex>();



			return builder;
		}
	}
}   
