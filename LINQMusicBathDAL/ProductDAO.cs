using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQMusicBathBDO;

namespace LINQMusicBathDAL
{
    public class ProductDAO
    {
        public ProductBDO GetProduct(int id)
        {
            ProductBDO productBDO = null;
            using (var MBEntities = new MusicBathEntities())
            {
                Products product = (from s in MBEntities.Products
                                    where s.ProductID == id
                                    select s).FirstOrDefault();
                if (product != null)
                    productBDO = new ProductBDO()
                    {
                        ProductID = product.ProductID,
                        ProductName = product.ProductName,
                        QuantityPerUnit = product.QuantityPerUnit,
                        UnitPrice = (decimal)product.UnitPrice,
                        UnitsInStock = (int)product.UnitsInStock,
                        ReorderLevel = (int)product.ReorderLevel,
                        UnitsOnOrder = (int)product.UnitsOnOrder,
                        RowVersion = product.Rowversion
                    };
            }
            return productBDO;
        }

        public bool UpdateProduct(
    ref ProductBDO productBDO,
    ref string message)
        {
            message = "product updated successfully";
            bool ret = true;
            using (var MBEntities = new MusicBathEntities())
            {
                var productID = productBDO.ProductID;
                Products productInDB =
                        (from p
                        in MBEntities.Products
                         where p.ProductID == productID
                         select p).FirstOrDefault();
                // check product
                if (productInDB == null)
                {
                    throw new Exception("No product with ID " +
                                        productBDO.ProductID);
                }
                MBEntities.Products.Remove(productInDB);
                // update product
                productInDB.ProductName = productBDO.ProductName;
                productInDB.QuantityPerUnit = productBDO.QuantityPerUnit;
                productInDB.UnitPrice = productBDO.UnitPrice;
                productInDB.Discontinued = productBDO.Discontinued;
                productInDB.Rowversion = productBDO.RowVersion;
                MBEntities.Products.Attach(productInDB);
                MBEntities.Entry(productInDB).State =
                    System.Data.EntityState.Modified;
                int num = MBEntities.SaveChanges();
                productBDO.RowVersion = productInDB.Rowversion;
                if (num != 1)
                {
                    ret = false;
                    message = "no product is updated";
                }
            }
            return ret;
        }
    }
}