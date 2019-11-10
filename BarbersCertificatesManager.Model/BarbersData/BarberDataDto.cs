using Ganss.Excel;

namespace BarbersCertificatesManager.Model.BarbersData
{
	public class BarberDataDto
	{
		[Column("ФИО")]
		public string FullName { get; set; }

		[Column("Квалификация")]
		public string Qualification { get; set; }

		[Column("Дата выдачи")]
		public string ReleaseDate { get; set; }

		[Column("Место выдачи")]
		public string ReleasePlace { get; set; }
	}
}