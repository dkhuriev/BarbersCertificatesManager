using System.Collections.Generic;
using System.IO;
using BarbersCertificatesManager.Model.BarbersData;
using TemplateEngine.Docx;

namespace BarbersCertificatesManager.Model.Certificates
{
	public static class BarberCertificateManager
	{
		public static void CreateCertificates(IEnumerable<BarberDataDto> barbersData, string templatePath, string outputPath)
		{
			foreach (var barberData in barbersData)
			{
				var certificatePath = Path.Combine(outputPath, $"{barberData.FullName}.docx");

				File.Delete(certificatePath);

				File.Copy(templatePath, certificatePath);

				var dataToFill = new Content(
					new FieldContent("Qualification", barberData.Qualification),
					new FieldContent("FullName", barberData.FullName),
					new FieldContent("ReleaseDate", barberData.ReleaseDate),
					new FieldContent("ReleasePlace", barberData.ReleasePlace));

				using (var templateProcessor = new TemplateProcessor(certificatePath).SetRemoveContentControls(true))
				{
					templateProcessor.FillContent(dataToFill);
					templateProcessor.SaveChanges();
				}
			}
		}
	}
}