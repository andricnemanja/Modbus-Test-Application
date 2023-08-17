﻿using ModelWcfServiceLibrary.EntityDataModel;
using ModelWcfServiceLibrary.Model.SignalMapping;
using System.Collections.Generic;
using System.Linq;

namespace ModelWcfServiceLibrary.DatabaseRepository
{
	public class DatabaseAnalogSignalMappingRepository : IDatabaseAnalogSignalMappingRepository
	{
		MiniScadaDB miniScadaDB;

		public List<ModelAnalogSignalMapping> AnalogMappingsList { get; private set; }

		public DatabaseAnalogSignalMappingRepository()
		{
			miniScadaDB = new MiniScadaDB();

			AnalogMappingsList = new List<ModelAnalogSignalMapping>();
		}

		public void MapFromDatabase()
		{
			List<DbMapping> signalMappingsDB = miniScadaDB.DbMappings.ToList();

			foreach (var analogmapping in signalMappingsDB)
			{
				if (analogmapping.mapping_type == 0)
				{
					ModelAnalogSignalMapping newAnalogMapping = new ModelAnalogSignalMapping()
					{
						Id = analogmapping.mapping_id,
						Name = analogmapping.mapping_name,
						K = (double)analogmapping.K,
						N = (double)analogmapping.N
					};

					AnalogMappingsList.Add(newAnalogMapping);
				}
			}
		}

		public ModelAnalogSignalMapping GetAnalogMappingByID(int id)
		{
			return AnalogMappingsList.SingleOrDefault(m => m.Id == id);
		}
	}
}
