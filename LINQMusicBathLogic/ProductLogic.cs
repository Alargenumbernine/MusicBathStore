using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQMusicBathBDO;
using LINQMusicBathDAL;

namespace LINQMusicBathLogic
{
    public class ProductLogic
    {
        ProductDAO productDAO = new ProductDAO();
        public ProductBDO GetProduct(int id)
        {
            return productDAO.GetProduct(id);
        }

        public bool UpdateProduct(
ref ProductBDO productBDO,
ref string message)
        {
            var productInDB =
            GetProduct(productBDO.ProductID);
            // invalid prod to update
            if (productInDB == null)
            {
                message = "cannot get product for this ID";
                return false;
            }
            if (productBDO.Discontinued == true
            && productInDB.UnitsOnOrder > 0)
            {
                message = "cannot discontinue this product";
                return false;
            }
            else
            {
                return productDAO.UpdateProduct(ref productBDO,
                ref message);
            }
        }
    }
}

