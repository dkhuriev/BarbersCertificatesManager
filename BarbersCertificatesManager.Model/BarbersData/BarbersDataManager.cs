using System;
using System.Collections.Generic;

namespace BarbersCertificatesManager.Model.BarbersData
{
	public class BarbersDataManager
	{
		public BarbersDataManager(IBarbersDataRepository barbersDataRepository)
		{
			_barbersDataRepository = barbersDataRepository ?? throw new ArgumentNullException(nameof(barbersDataRepository));
		}

		public IEnumerable<BarberDataDto> GetAllBarbersData()
		{
			return _barbersDataRepository.GetAllBarbersData();
		}

		private readonly IBarbersDataRepository _barbersDataRepository;
	}
}