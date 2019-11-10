using System.Collections.Generic;
using BarbersCertificatesManager.Model.BarbersData;
using BarbersCertificatesManager.Model.Certificates;

namespace BarbersCertificatesManager.Console
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			var barbersDataPath = args[0];
			var templatePath = args[1];
			var outputPath = args[2];

			var barbersData = GetAllBarbersData(barbersDataPath);

			BarberCertificateManager.CreateCertificates(barbersData, templatePath, outputPath);
		}

		private static IEnumerable<BarberDataDto> GetAllBarbersData(string dataPath)
		{
			var barbersDataManager = new BarbersDataManager(new ExcelBarbersDataRepository(dataPath));

			return barbersDataManager.GetAllBarbersData();
		}
	}
}