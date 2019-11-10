using System;
using System.Collections.Generic;
using System.IO;
using Ganss.Excel;

namespace BarbersCertificatesManager.Model.BarbersData
{
	public class ExcelBarbersDataRepository : IBarbersDataRepository
	{
		public ExcelBarbersDataRepository(string dataPath)
		{
			if (string.IsNullOrWhiteSpace(dataPath) && File.Exists(dataPath))
				throw new ArgumentException($"Non-existing barbers data path: {dataPath}");

			_excelMapper = new ExcelMapper(dataPath);
		}

		public IEnumerable<BarberDataDto> GetAllBarbersData()
		{
			return _excelMapper.Fetch<BarberDataDto>();
		}

		private readonly ExcelMapper _excelMapper;
	}
}