using System.Collections.Generic;
using UpgradeParadeTT.Models;

namespace UpgradeParadeTT.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetList();
        Product GetById(int id);
    }
}
