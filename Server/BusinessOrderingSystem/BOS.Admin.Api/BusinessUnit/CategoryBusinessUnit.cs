using BOS.Admin.Api.DataAccess;
using BOS.Admin.Api.Infrastructure.Model;
using BOS.Admin.Api.Infrastructure.Responses.ComplexTypes;
using BOS.Admin.Api.Infrastructure.Responses.Concrete;

namespace BOS.Admin.Api.BusinessUnit
{
    public interface ICategoryBusinessUnit
    {
        ServiceResponse Add(Category category);
        ServiceResponse Update(Category category);
        ServiceResponse Delete(Category category);
        Task<ServiceResponse<Category>> GetByIdAsync(int id);
    }

    public class CategoryBusinessUnit : ICategoryBusinessUnit
    {
        private readonly ICategoryDataAccess _categoryDataAccess;
        public CategoryBusinessUnit(ICategoryDataAccess categoryDataAccess)
        {
            _categoryDataAccess = categoryDataAccess;
        }

        public ServiceResponse Add(Category category)
        {
            var saveChangesValue = _categoryDataAccess.Add(category);

            if (saveChangesValue > 0)
            {
                return new ServiceResponse(ResponseCode.Success, "Category added successfuly");
            }
            return new ServiceResponse(ResponseCode.Fail, "Error. Failed to add category");

        }

        public ServiceResponse Update(Category category)
        {
            var oldCategory = _categoryDataAccess.GetByIdAsync(category.Id);
            if (oldCategory.Result == null)
            {
                return new ServiceResponse(ResponseCode.NotFound, "Not found Category object");
            }

            var saveChangesValue = _categoryDataAccess.Update(category);

            if (saveChangesValue == 0)
            {
                return new ServiceResponse(ResponseCode.Fail, "Error. Failed to updated category");
            }
            return new ServiceResponse(ResponseCode.Success, "Category updated successfuly");

        }

        public ServiceResponse Delete(Category category)
        {
            var oldCategory = _categoryDataAccess.GetByIdAsync(category.Id);
            if (oldCategory.Result == null)
            {
                return new ServiceResponse(ResponseCode.NotFound, "Not found Category object");
            }

            var saveChangesValue = _categoryDataAccess.Delete(category);

            if (saveChangesValue == 0)
            {
                return new ServiceResponse(ResponseCode.Fail, "Error. Failed to deleted category");
            }
            return new ServiceResponse(ResponseCode.Success, "Category deleted successfuly");

        }

        public async Task<ServiceResponse<Category>> GetByIdAsync(int id)
        {
            var category = await _categoryDataAccess.GetByIdAsync(id);
            if (category == null)
            {
                return new ServiceResponse<Category>(ResponseCode.NotFound, "Not found Category object");
            }
            return new ServiceResponse<Category>(ResponseCode.Success, category);
        }
    }
}
