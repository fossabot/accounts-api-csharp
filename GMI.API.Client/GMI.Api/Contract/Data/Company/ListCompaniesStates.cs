// These state is used to filter the companies by status in the ListCompaniesRequest
namespace GMI.Api.Contract.Data.Company {
  public enum ListCompaniesStates {
    Pending = -2,
    Inactive = -1,
    Any = 0,
    Active = 1,

  }
}