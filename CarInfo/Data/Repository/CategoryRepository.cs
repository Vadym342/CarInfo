using CarInfo.Data.Interfaces;
using CarInfo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo.Data.Repository
{
    public class CategoryRepository: ICarsCategory
    {
        private readonly AppDbContext appDBContext;

    public CategoryRepository(AppDbContext appDBContent)
    {
        this.appDBContext = appDBContent;
    }
    public IEnumerable<Category> AllCategories => appDBContext.Category;
    }
}
