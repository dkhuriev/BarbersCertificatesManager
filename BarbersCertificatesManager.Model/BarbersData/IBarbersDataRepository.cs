using System.Collections.Generic;

namespace BarbersCertificatesManager.Model.BarbersData
{
	public interface IBarbersDataRepository
	{
		IEnumerable<BarberDataDto> GetAllBarbersData();
	}
}