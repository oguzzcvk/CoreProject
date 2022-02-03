using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Conrete
{
    public class CategoryManager : ICategoryDal
    {
        //CategoryRepositories categoryRepositories = new CategoryRepositories();
        GenericRepository<Category> repo = new GenericRepository<Category>
        public void AddCategory(Category category)
        {
            if(category.CategoryName!=""&& category.CategoryDescription!=""&&
                category.CategoryName.Length>=5 && category.CategoryStatus == true)
            {
                repo.Delete(category);
                //categoryRepositories.AddCategory(category);
            }
            else
            {

            }
            
            
        }

        public void DeleteCategory(Category category)
        {
            //categoryRepositories.DeleteCategory(category);

        }

        public Category GetById(int id)
        {
            //return categoryRepositories.GetById(id);
        }

        public List<Category> ListAllCategory()
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
