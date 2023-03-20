using BOS.Admin.Api.DataAccess;
using BOS.Admin.Api.Infrastructure.Model;
using BOS.Admin.Api.Infrastructure.Responses.ComplexTypes;
using BOS.Admin.Api.Infrastructure.Responses.Concrete;

namespace BOS.Admin.Api.BusinessUnit
{
    public interface IBranchBusinessUnit
    {
        ServiceResponse Add(Branch branch);
        ServiceResponse Update(Branch branch);
        ServiceResponse Delete(Branch branch);
        Task<ServiceResponse<Branch>> GetByIdAsync(int id);
        Task<ServiceResponse<List<Branch>>> GetListAsync();

    }

    public class BranchBusinessUnit : IBranchBusinessUnit
    {
        private readonly IBranchDataAccess _branchDataAccess;

        public BranchBusinessUnit(IBranchDataAccess branchDataAccess)
        {
            _branchDataAccess = branchDataAccess;
        }

        public ServiceResponse Add(Branch branch)
        {
            var saveChangesValue = _branchDataAccess.Add(branch);

            if (saveChangesValue > 0)
            {
                return new ServiceResponse(ResponseCode.Success, "Branch added successfuly");
            }
            return new ServiceResponse(ResponseCode.Fail, "Error. Failed to add branch");

        }

        public ServiceResponse Update(Branch branch)
        {
            var oldBranch = _branchDataAccess.GetByIdAsync(branch.Id);
            if (oldBranch.Result == null)
            {
                return new ServiceResponse(ResponseCode.NotFound, "Not found Branch object");
            }

            var saveChangesValue = _branchDataAccess.Update(branch);

            if (saveChangesValue == 0)
            {
                return new ServiceResponse(ResponseCode.Fail, "Error. Failed to updated branch");
            }
            return new ServiceResponse(ResponseCode.Success, "Branch updated successfuly");

        }

        public ServiceResponse Delete(Branch branch)
        {
            var oldBranch = _branchDataAccess.GetByIdAsync(branch.Id);
            if (oldBranch.Result == null)
            {
                return new ServiceResponse(ResponseCode.NotFound, "Not found Branch object");
            }

            var saveChangesValue = _branchDataAccess.Delete(branch);

            if (saveChangesValue == 0)
            {
                return new ServiceResponse(ResponseCode.Fail, "Error. Failed to deleted branch");
            }
            return new ServiceResponse(ResponseCode.Success, "Branch deleted successfuly");

        }

        public async Task<ServiceResponse<Branch>> GetByIdAsync(int id)
        {
            var branch = await _branchDataAccess.GetByIdAsync(id);
            if (branch == null)
            {
                return new ServiceResponse<Branch>(ResponseCode.NotFound, "Not found Branch object");
            }
            return new ServiceResponse<Branch>(ResponseCode.Success, branch);
        }

        public async Task<ServiceResponse<List<Branch>>> GetListAsync()
        {
            var branchList = await _branchDataAccess.GetListAsync();
            if (branchList == null)
            {
                return new ServiceResponse<List<Branch>>(ResponseCode.NotFound, "Not found Branch object");
            }
            return new ServiceResponse<List<Branch>>(ResponseCode.Success, branchList);
        }

    }
}
