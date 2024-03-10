namespace MoviesAPI.Services
{
    public class CategoriesService : ICategories
    {
        public CategoriesService() { }

        public Response GetCategories()
        {
            return new Response();
        }

        public Response GetCategoryById(int id)
        {
            return new Response();
        }
        
        public Response AddCategory(Categories categories)
        {
            return new Response();
        }

        public Response DeleteCategory(int id)
        {
            return new Response();
        }

        public Response UpdateCategory(int id, Categories categories)
        {
            return new Response();
        }
    }
}
