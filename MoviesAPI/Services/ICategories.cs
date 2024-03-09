using MoviesAPI.Models;

namespace MoviesAPI.Services
{
    public interface ICategories
    {
            public Response GetCategories();
            public Response GetCategoryById(int id);
            public Response AddCategory(Categories categories);
            public Response DeleteCategory(int id);
            public Response UpdateCategory(int id, Categories categories);
    }
}
