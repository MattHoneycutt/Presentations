using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TryCatchFail.LearnStructureMap.Lesson1.Import
{
	public class BulkImporter : IBulkImporter
	{
		private readonly ImportSettings _settings;

		public BulkImporter(ImportSettings settings)
		{
			_settings = settings;
		}

		public void Import(IEnumerable<ProductData> products)
		{
			var table = new DataTable();
			table.Columns.Add("ProductID");
			table.Columns.Add("Description");
			table.Columns.Add("Price");

			using (var bulkCopy = new SqlBulkCopy(_settings.ConnectionString))
			{
				bulkCopy.DestinationTableName = "Products";
				bulkCopy.ColumnMappings.Add("ProductID", "ProductID");
				bulkCopy.ColumnMappings.Add("Description", "Description");
				bulkCopy.ColumnMappings.Add("Price", "Price");

				foreach (var product in products)
				{
					table.Rows.Add(product.ProductID, product.Description, product.ProductID);

					if (table.Rows.Count == _settings.BatchSize)
					{
						bulkCopy.WriteToServer(table);
						table.Rows.Clear();
					}
				}

				bulkCopy.WriteToServer(table);				
			}

		}
	}
}